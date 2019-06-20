namespace CharacterCreatorGUI
{
    partial class ProficienciesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProficiencies = new System.Windows.Forms.ListBox();
            this.lblCharacterProficiencies = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbModifyProficiency = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProficiencies
            // 
            this.lbProficiencies.BackColor = System.Drawing.Color.White;
            this.lbProficiencies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbProficiencies.FormattingEnabled = true;
            this.lbProficiencies.Location = new System.Drawing.Point(12, 25);
            this.lbProficiencies.Name = "lbProficiencies";
            this.lbProficiencies.Size = new System.Drawing.Size(332, 132);
            this.lbProficiencies.TabIndex = 0;
            this.lbProficiencies.SelectedIndexChanged += new System.EventHandler(this.lbProficiencies_SelectedIndexChanged);
            // 
            // lblCharacterProficiencies
            // 
            this.lblCharacterProficiencies.AutoSize = true;
            this.lblCharacterProficiencies.BackColor = System.Drawing.Color.White;
            this.lblCharacterProficiencies.Location = new System.Drawing.Point(12, 9);
            this.lblCharacterProficiencies.Name = "lblCharacterProficiencies";
            this.lblCharacterProficiencies.Size = new System.Drawing.Size(119, 13);
            this.lblCharacterProficiencies.TabIndex = 1;
            this.lblCharacterProficiencies.Text = "Character Proficiencies:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(12, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbModifyProficiency
            // 
            this.tbModifyProficiency.BackColor = System.Drawing.Color.White;
            this.tbModifyProficiency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbModifyProficiency.Location = new System.Drawing.Point(12, 165);
            this.tbModifyProficiency.Name = "tbModifyProficiency";
            this.tbModifyProficiency.Size = new System.Drawing.Size(332, 20);
            this.tbModifyProficiency.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(194, 200);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.Location = new System.Drawing.Point(12, 229);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinish.Location = new System.Drawing.Point(194, 229);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(150, 23);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // ProficienciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 259);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbModifyProficiency);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCharacterProficiencies);
            this.Controls.Add(this.lbProficiencies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProficienciesForm";
            this.Text = "Proficiencies";
            this.Load += new System.EventHandler(this.ProficienciesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProficiencies;
        private System.Windows.Forms.Label lblCharacterProficiencies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbModifyProficiency;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnFinish;
    }
}