using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CharacterCreationEngine;
using CharacterCreationEngine.Characteristics;

namespace CharacterCreatorGUI
{
    public partial class SkillsForm : Form
    {
        public CharaStatistic Stat { get; set; }
        private BindingList<Skills> _skills;
        private BindingList<int> _levels;
        public Dictionary<Skills, int> Skills { get; set; }

        public SkillsForm(CharaStatistic stat)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (stat != null)
            {
                Stat = stat;

                //these BindingLists are built from a dictionary and should always correspond
                //for example, ONE skill entry should ALWAYS correspond to ONE level entry
                //having an skill entry without a level entry or vice-versa is invalid
                _skills = BuildBindingList(Stat.Skills.Keys.ToList());
                _levels = BuildBindingList(Stat.Skills.Values.ToList());

                if (_skills.Count != _levels.Count)
                {
                    MessageBox.Show("Could not parse the Skills dictionary because the number of keys and values do not match.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    DialogResult = DialogResult.Cancel;

                    Close();
                }

                cbSkills.DataSource = Enum.GetValues(typeof(Skills));
                lbSkills.DataSource = _skills;
                lbLevels.DataSource = _levels;
            }
        }

        private void SkillsForm_Load(object sender, EventArgs e)
        {
            #region SetToolTips

            ToolTip startTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,

                ShowAlways = true
            };

            startTip.SetToolTip(btnAddSkill, "Adds a skill and skill level entry, based on entered and selected values.");
            startTip.SetToolTip(btnChangeSkill, "Modifies the selected skill entry.");
            startTip.SetToolTip(btnRemoveSkill, "Removes a selected skill and corresponding level entry.");
            startTip.SetToolTip(btnChangeLevel, "Modifies the selected level entry.");

            #endregion
        }

        private void lbSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSkills.DataSource == _skills && 
                lbLevels.DataSource == _levels)
            {
                lbLevels.SelectedIndex = lbSkills.SelectedIndex;
            }
        }

        private void lbLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSkills.DataSource == _skills &&
                   lbLevels.DataSource == _levels)
            {
                lbSkills.SelectedIndex = lbLevels.SelectedIndex;
            }
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if (cbSkills.SelectedIndex != -1 && 
                !string.IsNullOrEmpty(tbLevels.Text))
            {
                if (int.TryParse(tbLevels.Text, out int level))
                {
                    _skills.Add((Skills)cbSkills.SelectedItem);
                    _levels.Add(level);
                }
            }
        }
        
        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            //the two items must correspond
            if (lbSkills.SelectedIndex == lbLevels.SelectedIndex)
            {
                //the two items cannot be null
                if (lbSkills.SelectedItem != null &&
                    lbLevels.SelectedItem != null)
                {
                    int sIndex = lbSkills.SelectedIndex;
                    int lIndex = lbLevels.SelectedIndex;

                    //remove items from their respective list, by index number
                    //removes wrong entries if indices aren't checked again (???)
                    if (sIndex == lIndex)
                    {
                        _skills.RemoveAt(sIndex);
                        _levels.RemoveAt(lIndex);
                    }
                }
            }
        }

        private void btnChangeSkill_Click(object sender, EventArgs e)
        {
            if (lbSkills.SelectedItem != null &&
                cbSkills.SelectedIndex != -1)
            {
                Skills changeEntry = (Skills)lbSkills.SelectedItem;
                Skills newEntry = (Skills)cbSkills.SelectedItem;
                int indexOfChange = _skills.IndexOf(changeEntry);

                if (indexOfChange != -1)
                {
                    //the new/changed item gets added to the end of list if the old item is the last item in the list
                    if (indexOfChange == _skills.Count - 1)
                    {
                        _skills.RemoveAt(indexOfChange);
                        _skills.Add(newEntry);
                    }
                    //otherwise, replace the old item at its index
                    else
                    {
                        _skills.RemoveAt(indexOfChange);
                        _skills.Insert(indexOfChange, newEntry);
                    }

                    //ensure selected indices are the same for both lists after the change
                    lbSkills.SelectedIndex = indexOfChange;
                    lbLevels.SelectedIndex = indexOfChange;
                }
            }
        }

        private void btnChangeLevel_Click(object sender, EventArgs e)
        {
            if (lbLevels.SelectedItem != null &&
                int.TryParse(tbLevels.Text, out int level))
            {
                int changeEntry = (int)lbLevels.SelectedItem;
                int indexOfChange = _levels.IndexOf(changeEntry);

                if (indexOfChange != -1)
                {
                    //the new/changed item gets added to the end of list if the old item is the last item in the list
                    if (indexOfChange == _levels.Count - 1)
                    {
                        _levels.RemoveAt(indexOfChange);
                        _levels.Add(level);
                    }
                    //otherwise, replace the old item at its index
                    else
                    {
                        _levels.RemoveAt(indexOfChange);
                        _levels.Insert(indexOfChange, level);
                    }

                    //ensure selected indices are the same for both lists after the change
                    lbLevels.SelectedIndex = indexOfChange;
                    lbSkills.SelectedIndex = indexOfChange;
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Skills = RebuildSkillsDictionary(_skills, _levels);

            DialogResult = DialogResult.OK;

            MessageBox.Show("Remember to click \"Set Core\" in the Statistics form to apply your changes", "Finishing Skill Edits",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
        
        /// <summary>
        /// Non-destructively converts a List's structure into a BindingList.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputList"></param>
        /// <returns>Returns a BindingList of whatever type was submitted as an argument.</returns>
        private BindingList<T> BuildBindingList<T>(List<T> inputList) where T : IComparable
        {
            BindingList<T> result = new BindingList<T>();

            foreach (var item in inputList)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Combines two equal-count BindingList objects into a dictionary.
        /// </summary>
        /// <param name="skills"></param>
        /// <param name="levels"></param>
        /// <returns>Returns a dictionary representing all of a character's skills entries and their levels.</returns>
        private Dictionary<Skills, int> RebuildSkillsDictionary(BindingList<Skills> skills, BindingList<int> levels)
        {
            if (skills.Count != levels.Count)
            {
                MessageBox.Show("Both input BindingLists must be of the same count to be valid.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            Dictionary<Skills, int> result = new Dictionary<Skills, int>();

            for (int i = 0; i < skills.Count; i++)
            {
                result.Add(skills[i], levels[i]);
            }

            return result;
        }
        
    }
}
