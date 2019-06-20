using System;
using CharacterCreationEngine.Characteristics;
using System.Windows.Forms;

namespace CharacterCreatorGUI
{
    public partial class ProficienciesForm : Form
    {
        public CharaStatistic Stat { get; set; }

        public ProficienciesForm(CharaStatistic stat)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (stat != null)
            {
                Stat = stat;

                lbProficiencies.DataSource = Stat.Proficiencies;
                lbProficiencies.DisplayMember = "Proficiencies";
            }
        }

        private void ProficienciesForm_Load(object sender, EventArgs e)
        {
            #region SetToolTips

            ToolTip startTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,

                ShowAlways = true
            };

            startTip.SetToolTip(btnAdd, "Adds the entry in the lower textbox to the character's proficiencies list.");
            startTip.SetToolTip(btnChange, "Modifies the specified proficiency entry.");
            startTip.SetToolTip(btnRemove, "Removes the specified proficiency entry.");
            startTip.SetToolTip(btnFinish, "Saves all changes made to the character's proficiencies list.");

            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbModifyProficiency.Text))
            {
                Stat.AddProficiency(tbModifyProficiency.Text);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //both the selected item and the text in the textbox must have values
            if(lbProficiencies.SelectedItem != null &&
               !string.IsNullOrEmpty(tbModifyProficiency.Text))
            {
                //if these entries are equal, no change is needed
                if (lbProficiencies.SelectedItem.ToString().Equals(tbModifyProficiency.Text))
                {
                    return;
                }
                //if they differ, remove the old entry and add the new entry
                else
                {
                    Stat.RemoveProficiency(lbProficiencies.SelectedItem.ToString());

                    Stat.AddProficiency(tbModifyProficiency.Text);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbProficiencies.SelectedItem != null)
            {
                Stat.RemoveProficiency(lbProficiencies.SelectedItem.ToString());
            }
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            MessageBox.Show("Remember to click \"Set Core\" in the Statistics form to apply your changes", "Finishing Proficiency Edits",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void lbProficiencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbModifyProficiency.Text = lbProficiencies.SelectedItem.ToString();
            }
            catch
            {
                return;
            }
        }
        
    }
}
