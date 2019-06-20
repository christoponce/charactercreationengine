using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CharacterCreationEngine;
using CharacterCreationEngine.Extensions;
using CharacterCreationEngine.Characteristics;

namespace CharacterCreatorGUI
{
    public partial class StatsForm : Form
    {
        //holds the Creature object passed to this form so its Stats can be modified
        public Creature Creature { get; set; }
        private CharaStatistic Stat { get; set; }

        public StatsForm(Creature creature)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //set secondary attribute textboxes to readonly
            tbArmorClass.ReadOnly = true;
            tbInitiative.ReadOnly = true;
            tbSpeed.ReadOnly = true;
            tbPassiveWisdom.ReadOnly = true;

            //set the creature and the public Creature property for this form
            if (creature != null)
            {
                Creature = creature;
                Stat = creature.GetCharaStatistic() ?? new CharaStatistic();

                DisplayCreatureOnLoad(creature);
            }
            else
            {
                MessageBox.Show("Cannot changes the stats of a character that doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = DialogResult.Cancel;
                Close();
            }

            BringToFront();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            #region SetToolTips

            ToolTip startTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,

                ShowAlways = true
            };

            startTip.SetToolTip(btnSetCore, "Assigns all entered stats to the current character.");
            startTip.SetToolTip(btnRandomCore, "Rolls 4d6, drops the lowest value, and assigns the remaining sum\nto each of the 6 core attributes.");
            startTip.SetToolTip(btnClearAll, "Clears all fields.");
            startTip.SetToolTip(btnFinish, "Closes the stats box and returns to the character creation box.");

            #endregion
        }

        private void btnSetCore_Click(object sender, EventArgs e)
        {
            if (AllCoreAttributesHaveValue() && 
                ParseIntValues(out Dictionary<string, int> parsedInts))
            {
                if (AssignStatsValues(parsedInts))
                {
                    MessageBox.Show("Character attributes set.", "Attributes Set", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
        }
        
        private void btnRandomCore_Click(object sender, EventArgs e)
        {
            Random randGen = new Random();

            //if any textbox for the core stats has a value, ask user to roll new stats
            if (AnyCoreAttributesHaveValue())
            {
                DialogResult result = MessageBox.Show("One or more of the core attributes has a value already.\n\n" +
                                                      "Roll the 6 core attributes anyway?",
                                                      "Roll Core Attributes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    RollCoreAttributes(randGen);
                }
            }
            RollCoreAttributes(randGen);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //local function
            void Clear(Control.ControlCollection controls)
            {
                foreach (Control c in controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).Clear();
                    }
                    else if (c is ComboBox)
                    {
                        (c as ComboBox).SelectedIndex = -1;
                    }

                    Clear(c.Controls);
                }
            }

            Clear(Controls);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you're finished setting stats for this character?\n\n" + 
                                                  "If yes, remember to save your changes before exiting the program.",
                                                  "Finish Changing Stats", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void btnEditProficiencies_Click(object sender, EventArgs e)
        {
            //open modal dialog box to edit the list of proficiencies
            using (ProficienciesForm profForm = new ProficienciesForm(Stat))
            {
                profForm.ShowDialog(this);

                Stat.RebuildProficiency(profForm.Stat);
            }
        }

        private void btnEditSkills_Click(object sender, EventArgs e)
        {
            //open modal dialog box to edit the dictionary of skills
            using (SkillsForm skillsForm = new SkillsForm(Stat))
            {
                skillsForm.ShowDialog(this);

                Stat.RebuildSkills(skillsForm.Skills);
            }
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            //open modal dialog box to edit the dictionary of equipment
            using (EquipmentForm equipForm = new EquipmentForm(Stat))
            {
                equipForm.ShowDialog(this);

                Stat.RebuildEquipment(equipForm.Equipment);
            }
        }

        #region Methods

        /// <summary>
        /// Helper method for the RollCoreAttributes method. Get a result between 3 and 18.
        /// <para>This is the same as rolling 4d6 and ignoring the lowest rolled number and adding the rest together.</para>
        /// </summary>
        /// <param name="randGen"></param>
        /// <returns>Random number between 3 and 18. 19 is the cieling and is ignored in all rolls.</returns>
        private int RollCoreAttributesHelper(Random randGen)
        {
            //same as rolling 4d6, dropping the lowest roll, then adding the remaining rolls up
            return randGen.Next(3, 19);
        }

        /// <summary>
        /// Rolls random numbers for each Core Attribute, each being between 3 and 18.
        /// <para>Calls a method that sets the Secondary Attribute textboxes after all rolls have completed.</para>
        /// </summary>
        /// <param name="randGen"></param>
        private void RollCoreAttributes(Random randGen)
        {
            int dex = RollCoreAttributesHelper(randGen);
            int wis = RollCoreAttributesHelper(randGen);

            tbStrength.Text = $"{RollCoreAttributesHelper(randGen)}";
            tbConstitution.Text = $"{RollCoreAttributesHelper(randGen)}";
            tbWisdom.Text = $"{RollCoreAttributesHelper(randGen)}";
            tbCharisma.Text = $"{RollCoreAttributesHelper(randGen)}";
            tbIntelligence.Text = $"{RollCoreAttributesHelper(randGen)}";

            tbDexterity.Text = $"{dex}";
            tbWisdom.Text = $"{wis}";

            SetSecondaryAttributeTextBoxes(dex, wis);
        }

        /// <summary>
        /// Gets the race-specific speed attribute depending on the Crature object's Race setting.
        /// </summary>
        /// <param name="creature"></param>
        /// <returns></returns>
        private int GetSpeed(Creature creature)
        {
            switch (creature.GetRace())
            {
                case Race.Human:
                    return 30;
                case Race.Dwarf:
                    return 25;
                case Race.Elf:
                    return 30;
                case Race.Halfling:
                    return 25;
                case Race.Gnome:
                    return 25;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Checks all 6 core attribute textboxes to see if all of them have a value.
        /// </summary>
        /// <returns></returns>
        private bool AllCoreAttributesHaveValue()
        {
            if (!string.IsNullOrEmpty(tbStrength.Text) &&
                !string.IsNullOrEmpty(tbDexterity.Text) &&
                !string.IsNullOrEmpty(tbConstitution.Text) &&
                !string.IsNullOrEmpty(tbWisdom.Text) &&
                !string.IsNullOrEmpty(tbCharisma.Text) &&
                !string.IsNullOrEmpty(tbIntelligence.Text))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks all 6 core attribute textboxes to see if any of them have a value.
        /// </summary>
        /// <returns></returns>
        private bool AnyCoreAttributesHaveValue()
        {
            if (!string.IsNullOrEmpty(tbStrength.Text) ||
                !string.IsNullOrEmpty(tbDexterity.Text) ||
                !string.IsNullOrEmpty(tbConstitution.Text) ||
                !string.IsNullOrEmpty(tbWisdom.Text) ||
                !string.IsNullOrEmpty(tbCharisma.Text) ||
                !string.IsNullOrEmpty(tbIntelligence.Text))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets the Secondary Attribute textboxes based on the values of the core attributes.
        /// </summary>
        /// <param name="dex"></param>
        /// <param name="wis"></param>
        private void SetSecondaryAttributeTextBoxes(int dex, int wis)
        {
            int armor = 10 + dex;
            int pasWis = 10 + wis;
            int init = dex;

            tbArmorClass.Text = $"{armor}";
            tbInitiative.Text = $"{init}";
            tbSpeed.Text = $"{GetSpeed(Creature)}";
            tbPassiveWisdom.Text = $"{pasWis}";
        }

        /// <summary>
        /// Assigns parsed values and values from the stats form to a character's stats.
        /// </summary>
        /// <param name="parsedCoreInts"></param>
        private bool AssignStatsValues(Dictionary<string, int> parsedCoreInts)
        {
            try
            {
                //assign values to variables for readability
                int str = parsedCoreInts["Strength"];
                int dex = parsedCoreInts["Dexterity"];
                int cons = parsedCoreInts["Constitution"];
                int wis = parsedCoreInts["Wisdom"];
                int charis = parsedCoreInts["Charisma"];
                int intel = parsedCoreInts["Intelligence"];

                //assign secondary attributes
                Stat.ArmorClass = 10 + dex;
                Stat.Initiative = dex;
                Stat.PassiveWisdom = 10 + wis;
                Stat.Speed = GetSpeed(Creature);

                //assign string values
                Stat.PersonalityTraits = rtbPersonalityTraits.Text ?? "";
                Stat.Flaws = rtbFlaws.Text ?? "";
                Stat.Bonds = rtbBonds.Text ?? "";
                Stat.Ideals = rtbIdeals.Text ?? "";

                //assign core attributes
                Stat.Strength = str;
                Stat.Dexterity = dex;
                Stat.Constitution = cons;
                Stat.Wisdom = wis;
                Stat.Charisma = charis;
                Stat.Intelligence = intel;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        /// <summary>
        /// Tries to parse all int values in the stats form as usable int data to assign as character stats.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>Returns a populated dictionary as an out reference and TRUE if all parsing succeeded.</returns>
        private bool ParseIntValues(out Dictionary<string, int> result)
        {
            result = new Dictionary<string, int>();

            //out references
            int str = -1, dex = -1, cons = -1,
                wis = -1, charis = -1, intel = -1;

            //TryParse statements
            if ( int.TryParse(tbStrength.Text, out str) &&
                 int.TryParse(tbDexterity.Text, out dex) &&
                 int.TryParse(tbConstitution.Text, out cons) &&
                 int.TryParse(tbWisdom.Text, out wis) &&
                 int.TryParse(tbCharisma.Text, out charis) &&
                 int.TryParse(tbIntelligence.Text, out intel) )
            {
                //add parsed value to dictionary
                result.Add("Strength", str);
                result.Add("Dexterity", dex);
                result.Add("Constitution", cons);
                result.Add("Wisdom", wis);
                result.Add("Charisma", charis);
                result.Add("Intelligence", intel);

                return true;
            }
            return false;
        }

        /// <summary>
        /// Displays a Creature object's stats in the stats form.
        /// </summary>
        private void DisplayCreatureOnLoad(Creature creature)
        {
            if (Stat != null)
            {
                //core attributes
                tbStrength.Text = $"{Stat.Strength}";
                tbDexterity.Text = $"{Stat.Dexterity}";
                tbConstitution.Text = $"{Stat.Constitution}";
                tbWisdom.Text = $"{Stat.Wisdom}";
                tbCharisma.Text = $"{Stat.Charisma}";
                tbIntelligence.Text = $"{Stat.Intelligence}";

                //secondary attributes
                tbPassiveWisdom.Text = $"{Stat.PassiveWisdom}";
                tbArmorClass.Text = $"{Stat.ArmorClass}";
                tbInitiative.Text = $"{Stat.Initiative}";
                tbSpeed.Text = $"{Stat.Speed}";

                //string attributes
                rtbFlaws.Text = $"{Stat.Flaws}";
                rtbBonds.Text = $"{Stat.Bonds}";
                rtbIdeals.Text = $"{Stat.Ideals}";
                rtbPersonalityTraits.Text = $"{Stat.PersonalityTraits}";
            }
            //TODO: Add support for displaying and editing the Proficiencies, Skills, and Equipement of a character
        }

        #endregion
        
    }
}
