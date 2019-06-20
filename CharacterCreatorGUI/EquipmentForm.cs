using CharacterCreationEngine.Characteristics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CharacterCreatorGUI
{
    public partial class EquipmentForm : Form
    {
        public CharaStatistic Stat { get; set; }
        public Dictionary<string, int> Equipment { get; set; }
        private BindingList<string> _equipment;
        private BindingList<int> _weight;

        public EquipmentForm(CharaStatistic stat)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (stat != null)
            {
                Stat = stat;

                //these BindingLists are built from a dictionary and should always correspond
                //for example, ONE equipment entry should ALWAYS correspond to ONE weight entry
                //having an equipment entry without a weight entry or vice-versa is invalid
                _equipment = BuildBindingList(Stat.Equipment.Keys.ToList());
                _weight = BuildBindingList(Stat.Equipment.Values.ToList());

                if (_equipment.Count != _weight.Count)
                {
                    MessageBox.Show("Could not parse the Equipment dictionary because the number of keys and values do not match.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    DialogResult = DialogResult.Cancel;

                    Close();
                }

                lbEquipment.DataSource = _equipment;
                lbWeight.DataSource = _weight;
            }
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            #region SetToolTips

            ToolTip startTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,

                ShowAlways = true
            };

            startTip.SetToolTip(btnAddEquipment, "Adds a new equipment and corresponding weight entry, based on the textbox values.");
            startTip.SetToolTip(btnChangeEquipment, "Modifies the selected equipment entry.");
            startTip.SetToolTip(btnChangeWeight, "Modifies the selected weight entry.");
            startTip.SetToolTip(btnRemoveEquipment, "Removes a selected equipment and corresponding weight entry.");

            #endregion
        }
        
        private void lbEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEquipment.DataSource == _equipment &&
                lbWeight.DataSource == _weight)
            {
                lbWeight.SelectedIndex = lbEquipment.SelectedIndex;
            }
        }

        private void lbWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEquipment.DataSource == _equipment &&
                lbWeight.DataSource == _weight)
            {
                lbEquipment.SelectedIndex = lbWeight.SelectedIndex;
            }
        }
        
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEquipment.Text) &&
                !string.IsNullOrEmpty(tbWeight.Text))
            {
                if(int.TryParse(tbWeight.Text, out int weight))
                {
                    _equipment.Add(tbEquipment.Text);
                    _weight.Add(weight);
                }
            }
        }

        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            //the two items must correspond
            if (lbEquipment.SelectedIndex == lbWeight.SelectedIndex)
            {
                //the two items cannot be null
                if (lbEquipment.SelectedItem != null &&
                    lbWeight.SelectedItem != null)
                {
                    int eIndex = lbEquipment.SelectedIndex;
                    int wIndex = lbWeight.SelectedIndex;

                    //remove items from their respective list, by index number
                    //removes wrong entries if indices aren't checked again (???)
                    if (eIndex == wIndex)
                    {
                        _equipment.RemoveAt(eIndex);
                        _weight.RemoveAt(wIndex);
                    }
                }
            }
        }

        private void btnChangeEquipment_Click(object sender, EventArgs e)
        {
            if (lbEquipment.SelectedItem != null &&
                !string.IsNullOrEmpty(tbEquipment.Text))
            {
                string changeEntry = lbEquipment.SelectedItem.ToString();
                string newEntry = tbEquipment.Text;
                int indexOfChange = _equipment.IndexOf(changeEntry);

                if (indexOfChange != -1)
                {
                    //the new/changed item gets added to the end of list if the old item is the last item in the list
                    if (indexOfChange == _equipment.Count - 1)
                    {
                        _equipment.RemoveAt(indexOfChange);
                        _equipment.Add(newEntry);
                    }
                    //otherwise, replace the old item at its index
                    else
                    {
                        _equipment.RemoveAt(indexOfChange);
                        _equipment.Insert(indexOfChange, newEntry);
                    }

                    //ensure selected indices are the same for both lists after the change
                    lbEquipment.SelectedIndex = indexOfChange;
                    lbWeight.SelectedIndex = indexOfChange;
                }
            }
        }

        private void btnChangeWeight_Click(object sender, EventArgs e)
        {
            if (lbWeight.SelectedItem != null &&
                int.TryParse(tbWeight.Text, out int weight))
            {
                int changeEntry = (int)lbWeight.SelectedItem;
                int indexOfChange = _weight.IndexOf(changeEntry);

                if (indexOfChange != -1)
                {
                    //the new/changed item gets added to the end of list if the old item is the last item in the list
                    if (indexOfChange == _weight.Count - 1)
                    {
                        _weight.RemoveAt(indexOfChange);
                        _weight.Add(weight);
                    }
                    //otherwise, replace the old item at its index
                    else
                    {
                        _weight.RemoveAt(indexOfChange);
                        _weight.Insert(indexOfChange, weight);
                    }

                    //ensure selected indices are the same for both lists after the change
                    lbWeight.SelectedIndex = indexOfChange;
                    lbEquipment.SelectedIndex = indexOfChange;
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Equipment = RebuildEquipmentDictionary(_equipment, _weight);

            DialogResult = DialogResult.OK;

            MessageBox.Show("Remember to click \"Set Core\" in the Statistics form to apply your changes", "Finishing Equipment Edits",
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
        /// <param name="equipment"></param>
        /// <param name="weight"></param>
        /// <returns>Returns a dictionary representing all of a character's equipment entries and their weights.</returns>
        private Dictionary<string, int> RebuildEquipmentDictionary(BindingList<string> equipment, BindingList<int> weight)
        {
            if (equipment.Count != weight.Count)
            {
                MessageBox.Show("Both input BindingLists must be of the same count to be valid.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < equipment.Count; i++)
            {
                result.Add(equipment[i], weight[i]);
            }

            return result;
        }

    }
}
