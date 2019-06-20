namespace CharacterCreatorGUI
{
    partial class SkillsForm
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
            this.lbSkills = new System.Windows.Forms.ListBox();
            this.lbLevels = new System.Windows.Forms.ListBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblLevels = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.gbLevelControls = new System.Windows.Forms.GroupBox();
            this.btnChangeLevel = new System.Windows.Forms.Button();
            this.gbSkillsControls = new System.Windows.Forms.GroupBox();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.btnChangeSkill = new System.Windows.Forms.Button();
            this.tbLevels = new System.Windows.Forms.TextBox();
            this.cbSkills = new System.Windows.Forms.ComboBox();
            this.gbLevelControls.SuspendLayout();
            this.gbSkillsControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSkills
            // 
            this.lbSkills.BackColor = System.Drawing.Color.White;
            this.lbSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSkills.FormattingEnabled = true;
            this.lbSkills.Location = new System.Drawing.Point(15, 25);
            this.lbSkills.Name = "lbSkills";
            this.lbSkills.Size = new System.Drawing.Size(180, 171);
            this.lbSkills.TabIndex = 0;
            this.lbSkills.SelectedIndexChanged += new System.EventHandler(this.lbSkills_SelectedIndexChanged);
            // 
            // lbLevels
            // 
            this.lbLevels.BackColor = System.Drawing.Color.White;
            this.lbLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLevels.FormattingEnabled = true;
            this.lbLevels.Location = new System.Drawing.Point(202, 25);
            this.lbLevels.Name = "lbLevels";
            this.lbLevels.Size = new System.Drawing.Size(179, 171);
            this.lbLevels.TabIndex = 1;
            this.lbLevels.SelectedIndexChanged += new System.EventHandler(this.lbLevels_SelectedIndexChanged);
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.BackColor = System.Drawing.Color.White;
            this.lblSkills.Location = new System.Drawing.Point(12, 9);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(34, 13);
            this.lblSkills.TabIndex = 2;
            this.lblSkills.Text = "Skills:";
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.BackColor = System.Drawing.Color.White;
            this.lblLevels.Location = new System.Drawing.Point(198, 9);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(41, 13);
            this.lblLevels.TabIndex = 3;
            this.lblLevels.Text = "Levels:";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinish.Location = new System.Drawing.Point(208, 289);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(167, 23);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // gbLevelControls
            // 
            this.gbLevelControls.BackColor = System.Drawing.Color.White;
            this.gbLevelControls.Controls.Add(this.btnChangeLevel);
            this.gbLevelControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLevelControls.Location = new System.Drawing.Point(202, 230);
            this.gbLevelControls.Name = "gbLevelControls";
            this.gbLevelControls.Size = new System.Drawing.Size(180, 53);
            this.gbLevelControls.TabIndex = 14;
            this.gbLevelControls.TabStop = false;
            this.gbLevelControls.Text = "Levels";
            // 
            // btnChangeLevel
            // 
            this.btnChangeLevel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChangeLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeLevel.Location = new System.Drawing.Point(6, 19);
            this.btnChangeLevel.Name = "btnChangeLevel";
            this.btnChangeLevel.Size = new System.Drawing.Size(168, 23);
            this.btnChangeLevel.TabIndex = 7;
            this.btnChangeLevel.Text = "Change";
            this.btnChangeLevel.UseVisualStyleBackColor = false;
            this.btnChangeLevel.Click += new System.EventHandler(this.btnChangeLevel_Click);
            // 
            // gbSkillsControls
            // 
            this.gbSkillsControls.BackColor = System.Drawing.Color.White;
            this.gbSkillsControls.Controls.Add(this.btnRemoveSkill);
            this.gbSkillsControls.Controls.Add(this.btnAddSkill);
            this.gbSkillsControls.Controls.Add(this.btnChangeSkill);
            this.gbSkillsControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSkillsControls.Location = new System.Drawing.Point(15, 230);
            this.gbSkillsControls.Name = "gbSkillsControls";
            this.gbSkillsControls.Size = new System.Drawing.Size(180, 82);
            this.gbSkillsControls.TabIndex = 13;
            this.gbSkillsControls.TabStop = false;
            this.gbSkillsControls.Text = "Skills";
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveSkill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveSkill.Location = new System.Drawing.Point(6, 48);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(78, 23);
            this.btnRemoveSkill.TabIndex = 8;
            this.btnRemoveSkill.Text = "Remove";
            this.btnRemoveSkill.UseVisualStyleBackColor = false;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddSkill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSkill.Location = new System.Drawing.Point(6, 19);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(78, 23);
            this.btnAddSkill.TabIndex = 4;
            this.btnAddSkill.Text = "Add";
            this.btnAddSkill.UseVisualStyleBackColor = false;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // btnChangeSkill
            // 
            this.btnChangeSkill.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChangeSkill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeSkill.Location = new System.Drawing.Point(96, 19);
            this.btnChangeSkill.Name = "btnChangeSkill";
            this.btnChangeSkill.Size = new System.Drawing.Size(78, 23);
            this.btnChangeSkill.TabIndex = 7;
            this.btnChangeSkill.Text = "Change";
            this.btnChangeSkill.UseVisualStyleBackColor = false;
            this.btnChangeSkill.Click += new System.EventHandler(this.btnChangeSkill_Click);
            // 
            // tbLevels
            // 
            this.tbLevels.BackColor = System.Drawing.Color.White;
            this.tbLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevels.Location = new System.Drawing.Point(201, 204);
            this.tbLevels.Name = "tbLevels";
            this.tbLevels.Size = new System.Drawing.Size(180, 20);
            this.tbLevels.TabIndex = 11;
            // 
            // cbSkills
            // 
            this.cbSkills.BackColor = System.Drawing.Color.White;
            this.cbSkills.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSkills.FormattingEnabled = true;
            this.cbSkills.Location = new System.Drawing.Point(15, 204);
            this.cbSkills.Name = "cbSkills";
            this.cbSkills.Size = new System.Drawing.Size(180, 21);
            this.cbSkills.TabIndex = 15;
            // 
            // SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 326);
            this.Controls.Add(this.cbSkills);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.gbLevelControls);
            this.Controls.Add(this.gbSkillsControls);
            this.Controls.Add(this.tbLevels);
            this.Controls.Add(this.lblLevels);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lbLevels);
            this.Controls.Add(this.lbSkills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SkillsForm";
            this.Text = "SkillsForm";
            this.Load += new System.EventHandler(this.SkillsForm_Load);
            this.gbLevelControls.ResumeLayout(false);
            this.gbSkillsControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSkills;
        private System.Windows.Forms.ListBox lbLevels;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox gbLevelControls;
        private System.Windows.Forms.Button btnChangeLevel;
        private System.Windows.Forms.GroupBox gbSkillsControls;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.Button btnChangeSkill;
        private System.Windows.Forms.TextBox tbLevels;
        private System.Windows.Forms.ComboBox cbSkills;
    }
}