using System;
using System.Windows.Forms;

namespace CharacterCreatorGUI
{
    public partial class CreatorStartupForm : Form
    {
        public int Selection { get; set; }

        public CreatorStartupForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (rbOption1.Checked)
            {
                Selection = 0;
            }
            else
            {
                Selection = 1;
            }

            DialogResult = DialogResult.OK;

            Close();
        }
        
    }
}
