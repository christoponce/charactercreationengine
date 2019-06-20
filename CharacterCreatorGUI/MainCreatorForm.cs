using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CharacterCreationEngine;
using CharacterCreationEngine.Extensions;

namespace CharacterCreatorGUI
{
    public partial class MainCreatorForm : Form
    {
        #region PrivateStaticMembers

        private static DialogResult StartupResult { get; set; }
        private static Creature CurrentCharacter { get; set; }
        private static int StartupSelection { get; set; }
        private static string LoadedGUID { get; set; }
        private static bool ShouldSave { get; set; }

        #endregion

        public MainCreatorForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            #region PopulateComboBoxes

            //populate comboboxes with their relative enum values
            cbRelativeSize.DataSource = Enum.GetValues(typeof(RelativeSize));
            cbCreatureType.DataSource = Enum.GetValues(typeof(CreatureType));
            cbCombatClass.DataSource = Enum.GetValues(typeof(CombatClass));
            cbBackground.DataSource = Enum.GetValues(typeof(Background));
            cbAlignment.DataSource = Enum.GetValues(typeof(Alignment));
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cbWings.DataSource = Enum.GetValues(typeof(Wings));
            cbDiet.DataSource = Enum.GetValues(typeof(Diet));
            cbTail.DataSource = Enum.GetValues(typeof(Tail));
            cbRace.DataSource = Enum.GetValues(typeof(Race));

            #endregion

            BringToFront();

            StartupResult = CreateStartupForm();
            StartCreator(StartupSelection);
        }

        private void MainCreatorForm_Load(object sender, EventArgs e)
        {
            //set ShouldSave to false;
            ShouldSave = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShouldSave)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to create a new character?\n\n" +
                                                      "This will clear all fields and all unsaved changes will be lost.\n\n" +
                                                      "Continue?",
                                                      "Create New", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    ClearAllCreatorControls();

                    CurrentCharacter = null;
                    LoadedGUID = string.Empty;

                    tbFirstName.Focus();
                }

                return;
            }

            //if shouldSave is false, no recent changes have been made
            //clear all, focus the first textbox
            ClearAllCreatorControls();

            tbFirstName.Focus();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cXML = new CreatureXML();

            //no "data loss" warning if no character has been loaded already OR no unsaved character has been built yet
            if (CurrentCharacter == null)
            {
                try
                {
                    CurrentCharacter = cXML.ReadFromXML(GetXMLToOpen());

                    if (CurrentCharacter != null)
                    {
                        DisplayCreature(CurrentCharacter);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //"data loss" warning if a character has already been loaded OR an unsaved character has been built
            else
            {
                DialogResult result = MessageBox.Show("Opening a character file will cause all changes for this character to be lost. Continue?",
                                                      "Open a Character", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        CurrentCharacter = cXML.ReadFromXML(GetXMLToOpen());

                        if (CurrentCharacter != null)
                        {
                            DisplayCreature(CurrentCharacter);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cXML = new CreatureXML();

            if (CurrentCharacter != null)
            {
                try
                {
                    cXML.WriteToXML(GetXMLToSave(), CurrentCharacter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ShouldSave = false;
            }
            else
            {
                MessageBox.Show("This character must be built before it can be saved.\n\n" + 
                                "Go to \"Options\" then click \"Build Character\" and try again.", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShouldSave)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?\n\n" +
                                                      "All unsaved changes will be lost.\n\n" +
                                                      "Continue?",
                                                      "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }

                return;
            }

            Application.Exit();
        }

        private void characterStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                DialogResult result;

                //open the StatsForm as a modal dialog box to edit the Stats of the current character
                using (StatsForm statsForm = new StatsForm(CurrentCharacter))
                {
                    result = statsForm.ShowDialog(this);

                    //reassign Data with the edited Creature object
                    CurrentCharacter = statsForm.Creature;
                }
            }
            else
            {
                MessageBox.Show("Cannot set stats on a Character that does not exist.\n\n" +
                                "If you are editing an existing character, its XML file may be corrupt.\n\n" +
                                "Try clicking \"Edit\", then \"Generate GUID\" to rebuild the character and try again.",
                                "Error Setting Stats", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buildCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentCharacter != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to build this Character?\n\n" +
                                                          "Currently-loaded character information will be disgarded.",
                                                          "Build Character and Generate GUID",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        CurrentCharacter = BuildCreature();

                        LoadedGUID = CurrentCharacter.GetCreatureGUIDAsString() ?? string.Empty;
                        tbGUID.Text = CurrentCharacter.GetCreatureGUIDAsString().ToUpper() ?? string.Empty;
                    }
                }
                else
                {
                    CurrentCharacter = BuildCreature();

                    LoadedGUID = CurrentCharacter.GetCreatureGUIDAsString() ?? string.Empty;
                    tbGUID.Text = CurrentCharacter.GetCreatureGUIDAsString().ToUpper() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n\n" + 
                                "Note: Attempting to build a character while leaving fields other than \"Surname\" or \"Subrace\" empty " + 
                                "will result in failure. Please check all other fields then try to build the character again.", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void useRandomSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                DialogResult result = MessageBox.Show("Using random settings will cause any unsaved changes in the creation form to be lost.\n\nContinue?",
                                                      "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    RandomRacialSettings();
                }
            }
            else
            {
                RandomRacialSettings();
            }
        }

        #region EventsTriggerSaveAlert

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            ShouldSave = true;
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
            ShouldSave = true;
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            ShouldSave = true;
        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            ShouldSave = true;
        }

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {
            ShouldSave = true;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetGender((Gender)cbGender.SelectedValue);
            }
            ShouldSave = true;
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do this if an existing character file was open OR if a new character was built
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetRace((Race)cbRace.SelectedValue);

                CreatureBuilder cb = new CreatureBuilder((Race)cbRace.SelectedItem);
                Creature nc = cb.NewCreature;

                rtbRaceDescription.Text = nc.GetDescription();

                ShouldSave = true;

                return;
            }

            //do this if CurrentCharacter is null, but the Race combobox is having its options cycled through
            if (cbRace.SelectedItem != null)
            {
                Race race = (Race)cbRace.SelectedItem;

                CreatureBuilder cb = new CreatureBuilder(race);
                Creature nc = cb.NewCreature;

                rtbRaceDescription.Text = nc.GetDescription();

                ShouldSave = true;
            }
            else
            {
                return;
            }

            //if all else fails, clear the race description rtb
            rtbRaceDescription.Clear();
        }

        private void cbCreatureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetCreatureType((CreatureType)cbCreatureType.SelectedValue);
            }
            ShouldSave = true;
        }

        private void cbDiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetDiet((Diet)cbDiet.SelectedValue);
            }
            ShouldSave = true;
        }

        private void tbSubrace_TextChanged(object sender, EventArgs e)
        {
            ShouldSave = true;
        }

        private void cbTail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetTail((Tail)cbTail.SelectedValue);
            }
            ShouldSave = true;
        }

        private void cbCombatClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetCombatClass((CombatClass)cbCombatClass.SelectedValue);
            }
            ShouldSave = true;
        }

        private void cbRelativeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetRelativeSize((RelativeSize)cbRelativeSize.SelectedValue);
            }
            ShouldSave = true;
        }

        private void cbBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetBackground((Background)cbBackground.SelectedValue);
            }
            ShouldSave = true;
        }

        private void cbAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentCharacter != null)
            {
                CurrentCharacter.SetAlignment((Alignment)cbAlignment.SelectedValue);
            }
            ShouldSave = true;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Opens a child form as a modal dialog box to see what the user's intentions are.
        /// </summary>
        /// <returns></returns>
        private DialogResult CreateStartupForm()
        {
            DialogResult result;

            using (CreatorStartupForm startupForm = new CreatorStartupForm())
            {
                result = startupForm.ShowDialog(this);

                StartupSelection = startupForm.Selection;
            }

            return result;
        }

        /// <summary>
        /// Sets up the main creation form based on what the user chose during startup.
        /// </summary>
        /// <param name="selection"></param>
        private void StartCreator(int selection)
        {
            CurrentCharacter = null;

            //create new character
            if (selection == 0)
            {
                //clear all creator controls
                ClearAllCreatorControls();

                CurrentCharacter = null;

                //focus first control
                tbFirstName.Focus();
            }
            //open existing character file (*.xml)
            else if (selection == 1)
            {
                var cXML = new CreatureXML();

                try
                {
                    CurrentCharacter = cXML.ReadFromXML(GetXMLToOpen());

                    if (CurrentCharacter != null)
                    {
                        //track the GUID of the loaded Creature
                        LoadedGUID = CurrentCharacter.GetCreatureGUIDAsString();

                        DisplayCreature(CurrentCharacter);
                    }

                }
                catch (Exception ex)
                {
                    CurrentCharacter = null;
                    LoadedGUID = string.Empty;

                    MessageBox.Show($"Error: {ex.Message}", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Clears all controls related to character creation.
        /// </summary>
        private void ClearAllCreatorControls()
        {
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

        /// <summary>
        /// Displays the attributes of a Creature object via the controls of the creation form.
        /// </summary>
        /// <param name="creature"></param>
        private void DisplayCreature(Creature creature)
        {
            //personal information
            tbFirstName.Text = creature.GetFirstName() ?? "";
            tbSurname.Text = creature.GetSurname() ?? "";
            tbAge.Text = creature.GetAge().ToString();
            cbGender.SelectedItem = creature.GetGender();
            tbHeight.Text = creature.GetHeight().ToString();
            tbWeight.Text = creature.GetWeight().ToString();

            //racial information
            rtbRaceDescription.Text = creature.GetDescription();
            cbRace.SelectedItem = creature.GetRace();
            cbCreatureType.SelectedItem = creature.GetCreatureType();
            cbDiet.SelectedItem = creature.GetDiet();
            cbTail.SelectedItem = creature.GetTail();
            cbWings.SelectedItem = creature.GetWings();
            tbSubrace.Text = creature.GetSubrace() ?? "";

            //misc information
            cbCombatClass.SelectedItem = creature.GetCombatClass();
            cbRelativeSize.SelectedItem = creature.GetRelativeSize();
            cbBackground.SelectedItem = creature.GetBackground();
            cbAlignment.SelectedItem = creature.GetAlignment();

            //creature GUID
            tbGUID.Text = creature.GetCreatureGUIDAsString().ToUpper();
        }

        /// <summary>
        /// Starts an OpenFileDialog box and gets the full path and file name of a target XML file.
        /// </summary>
        /// <returns>Returns a string representing the full path and file name of a target XML file.</returns>
        private string GetXMLToOpen()
        {
            DialogResult result;
            string fileName;

            using (var fileSelector = new OpenFileDialog())
            {
                fileSelector.DefaultExt = "xml";
                result = fileSelector.ShowDialog();
                fileName = fileSelector.FileName;
            }

            if (result == DialogResult.OK && !string.IsNullOrEmpty(fileName))
            {
                return fileName;
            }

            return string.Empty;
        }

        /// <summary>
        /// Starts an SaveFileDialog box and gets the full path and file name of a target XML file.
        /// </summary>
        /// <returns>Returns a string representing the full path and file name of a target XML file.</returns>
        private string GetXMLToSave()
        {
            DialogResult result;
            string fileName;

            using (var fileSelector = new SaveFileDialog())
            {
                fileSelector.CheckFileExists = false;
                fileSelector.Filter = "XML Files | *.xml";
                fileSelector.DefaultExt = "xml";

                result = fileSelector.ShowDialog();
                fileName = fileSelector.FileName;
            }

            if (result == DialogResult.OK && !string.IsNullOrEmpty(fileName))
            {
                return fileName;
            }

            return string.Empty;
        }

        /// <summary>
        /// Parses all values from the creation form to create a new Creature object.
        /// </summary>
        /// <returns>Returns an object of a class that derives from the Creature class.</returns>
        private Creature BuildCreature()
        {
            if (ParseEnumValues(out Dictionary<string, Enum> parsedEnums) &&
                ParseIntValues(out Dictionary<string, int> parsedInts) &&
                !string.IsNullOrEmpty(tbFirstName.Text))
            {
                //do this if building a NEW character
                if (CurrentCharacter == null)
                {
                    //create a new creature with a derived type specified by the "Race" setting
                    CreatureBuilder cb = new CreatureBuilder((Race)parsedEnums["Race"]);
                    Creature newCreature = cb.NewCreature;

                    //assign parsed values to the new Creature object
                    AssignValues(newCreature, parsedEnums, parsedInts);

                    LoadedGUID = newCreature.GetCreatureGUIDAsString();
                    tbGUID.Text = newCreature.GetCreatureGUIDAsString().ToUpper();

                    return newCreature;
                }
                //do this if building on an EXISTING character
                else
                {
                    //assign parsed values to the current character
                    //will change the values of the CurrentCharacter property
                    AssignValues(CurrentCharacter, parsedEnums, parsedInts);

                    Creature existingCreature = CurrentCharacter;

                    LoadedGUID = CurrentCharacter.GetCreatureGUIDAsString();
                    tbGUID.Text = CurrentCharacter.GetCreatureGUIDAsString().ToUpper();

                    return existingCreature;
                }
            }
            else
            {
                MessageBox.Show("Error: The character could not be created because a value failed to parse correctly.\n\n" +
                                "The only two fields that can be empty are the Subrace and Surname fields.\n\n" +
                                "Fields that are meant to contain numbers can only contain numbers, usually positive integers.\n\n" +
                                "Please check all other fields and try again.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        /// <summary>
        /// Tries to parse all enum values in the creation form as usable enum data to assign to a Creature object.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>Returns a populated dictionary as an out reference and TRUE if all parsing succeeded.</returns>
        private bool ParseEnumValues(out Dictionary<string, Enum> result)
        {
            result = new Dictionary<string, Enum>();
            
            //TryParse statements
            if (Enum.TryParse(cbGender.SelectedValue.ToString(), out Gender gender) &&
                Enum.TryParse(cbCreatureType.SelectedValue.ToString(), out CreatureType creatureType) &&
                Enum.TryParse(cbDiet.SelectedValue.ToString(), out Diet diet) &&
                Enum.TryParse(cbTail.SelectedValue.ToString(), out Tail tail) &&
                Enum.TryParse(cbCombatClass.SelectedValue.ToString(), out CombatClass combatClass) &&
                Enum.TryParse(cbRelativeSize.SelectedValue.ToString(), out RelativeSize relativeSize) &&
                Enum.TryParse(cbBackground.SelectedValue.ToString(), out Background background) &&
                Enum.TryParse(cbAlignment.SelectedValue.ToString(), out Alignment alignment) &&
                Enum.TryParse(cbWings.SelectedValue.ToString(), out Wings wings) &&
                Enum.TryParse(cbRace.SelectedValue.ToString(), out Race race))
            {
                //add parsed results to dictionary
                result.Add("Gender", gender);
                result.Add("CreatureType", creatureType);
                result.Add("Diet", diet);
                result.Add("Tail", tail);
                result.Add("CombatClass", combatClass);
                result.Add("RelativeSize", relativeSize);
                result.Add("Background", background);
                result.Add("Alignment", alignment);
                result.Add("Wings", wings);
                result.Add("Race", race);

                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to parse all int values in the creation form as usable int data to assign to a Creature object.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>Returns a populated dictionary as an out reference and TRUE if all parsing succeeded.</returns>
        private bool ParseIntValues(out Dictionary<string, int> result)
        {
            result = new Dictionary<string, int>();
            
            //out references
            int age = -1, height = -1, weight = -1;

            //TryParse statements
            if (int.TryParse(tbAge.Text, out age) &&
                int.TryParse(tbHeight.Text, out height) &&
                int.TryParse(tbWeight.Text, out weight))
            {
                //add results to dictionary
                result.Add("Age", age);
                result.Add("Height", height);
                result.Add("Weight", weight);

                return true;
            }
            return false;
        }

        /// <summary>
        /// Assigns parsed int and enum values to their appropriate properties in a Creature object.
        /// </summary>
        /// <param name="creature"></param>
        /// <param name="parsedEnums"></param>
        /// <param name="parsedInts"></param>
        private void AssignValues(Creature creature, Dictionary<string, Enum> parsedEnums, Dictionary<string, int> parsedInts)
        {
            //set all values from textboxes
            creature.SetSurname(tbSurname.Text ?? "");
            creature.SetSubrace(tbSubrace.Text ?? "");
            creature.SetFirstName(tbFirstName.Text);
            creature.SetAge(parsedInts["Age"]);
            creature.SetHeight(parsedInts["Height"]);
            creature.SetWeight(parsedInts["Weight"]);

            //set all values from comboboxes
            creature.SetCreatureType((CreatureType)parsedEnums["CreatureType"]);
            creature.SetRelativeSize((RelativeSize)parsedEnums["RelativeSize"]);
            creature.SetCombatClass((CombatClass)parsedEnums["CombatClass"]);
            creature.SetBackground((Background)parsedEnums["Background"]);
            creature.SetAlignment((Alignment)parsedEnums["Alignment"]);
            creature.SetGender((Gender)parsedEnums["Gender"]);
            creature.SetDiet((Diet)parsedEnums["Diet"]);
            creature.SetTail((Tail)parsedEnums["Tail"]);
            creature.SetRace((Race)parsedEnums["Race"]);

            //assigns the LoadedGUID value to the Creature object if it isn't null
            //otherwise, the new Creature will use the GUID it generated when it was created
            if (!string.IsNullOrEmpty(LoadedGUID))
            {
                creature.SetCreatureGUID(Guid.Parse(LoadedGUID));
            }
        }

        /// <summary>
        /// Sets the comboboxes and some select textboxes to random values.
        /// </summary>
        private void RandomRacialSettings()
        {
            Random randGen = new Random();

            //set non-naming textboxes to random values
            tbAge.Text = $"{randGen.Next(18, 101)}";
            tbHeight.Text = $"{randGen.Next(36, 85)}";
            tbWeight.Text = $"{randGen.Next(30, 300)}";

            //set all comboboxes to a random value
            cbCreatureType.SelectedIndex = randGen.Next(0, cbCreatureType.Items.Count);
            cbRelativeSize.SelectedIndex = randGen.Next(0, cbRelativeSize.Items.Count);
            cbCombatClass.SelectedIndex = randGen.Next(0, cbCombatClass.Items.Count);
            cbBackground.SelectedIndex = randGen.Next(0, cbBackground.Items.Count);
            cbAlignment.SelectedIndex = randGen.Next(0, cbAlignment.Items.Count);
            cbGender.SelectedIndex = randGen.Next(0, cbGender.Items.Count);
            cbWings.SelectedIndex = randGen.Next(0, cbWings.Items.Count);
            cbDiet.SelectedIndex = randGen.Next(0, cbDiet.Items.Count);
            cbTail.SelectedIndex = randGen.Next(0, cbTail.Items.Count);
            cbRace.SelectedIndex = randGen.Next(0, cbRace.Items.Count);
        }

        #endregion
        
    }
}
