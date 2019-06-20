namespace CharacterCreatorGUI
{
    partial class EquipmentForm
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
            this.lbEquipment = new System.Windows.Forms.ListBox();
            this.lbWeight = new System.Windows.Forms.ListBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.tbEquipment = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.btnChangeEquipment = new System.Windows.Forms.Button();
            this.gbEquipmentControls = new System.Windows.Forms.GroupBox();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.gbWeightControls = new System.Windows.Forms.GroupBox();
            this.btnChangeWeight = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.gbEquipmentControls.SuspendLayout();
            this.gbWeightControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEquipment
            // 
            this.lbEquipment.BackColor = System.Drawing.Color.White;
            this.lbEquipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEquipment.FormattingEnabled = true;
            this.lbEquipment.Location = new System.Drawing.Point(15, 25);
            this.lbEquipment.Name = "lbEquipment";
            this.lbEquipment.Size = new System.Drawing.Size(180, 158);
            this.lbEquipment.TabIndex = 0;
            this.lbEquipment.SelectedIndexChanged += new System.EventHandler(this.lbEquipment_SelectedIndexChanged);
            // 
            // lbWeight
            // 
            this.lbWeight.BackColor = System.Drawing.Color.White;
            this.lbWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWeight.FormattingEnabled = true;
            this.lbWeight.Location = new System.Drawing.Point(201, 25);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(180, 158);
            this.lbWeight.TabIndex = 1;
            this.lbWeight.SelectedIndexChanged += new System.EventHandler(this.lbWeight_SelectedIndexChanged);
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.BackColor = System.Drawing.Color.White;
            this.lblEquipment.Location = new System.Drawing.Point(12, 9);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(60, 13);
            this.lblEquipment.TabIndex = 2;
            this.lblEquipment.Text = "Equipment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weight:";
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEquipment.Location = new System.Drawing.Point(6, 19);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(78, 23);
            this.btnAddEquipment.TabIndex = 4;
            this.btnAddEquipment.Text = "Add";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // tbEquipment
            // 
            this.tbEquipment.BackColor = System.Drawing.Color.White;
            this.tbEquipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEquipment.Location = new System.Drawing.Point(15, 192);
            this.tbEquipment.Name = "tbEquipment";
            this.tbEquipment.Size = new System.Drawing.Size(180, 20);
            this.tbEquipment.TabIndex = 5;
            // 
            // tbWeight
            // 
            this.tbWeight.BackColor = System.Drawing.Color.White;
            this.tbWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWeight.Location = new System.Drawing.Point(201, 192);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(180, 20);
            this.tbWeight.TabIndex = 6;
            // 
            // btnChangeEquipment
            // 
            this.btnChangeEquipment.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChangeEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeEquipment.Location = new System.Drawing.Point(96, 19);
            this.btnChangeEquipment.Name = "btnChangeEquipment";
            this.btnChangeEquipment.Size = new System.Drawing.Size(78, 23);
            this.btnChangeEquipment.TabIndex = 7;
            this.btnChangeEquipment.Text = "Change";
            this.btnChangeEquipment.UseVisualStyleBackColor = false;
            this.btnChangeEquipment.Click += new System.EventHandler(this.btnChangeEquipment_Click);
            // 
            // gbEquipmentControls
            // 
            this.gbEquipmentControls.BackColor = System.Drawing.Color.White;
            this.gbEquipmentControls.Controls.Add(this.btnRemoveEquipment);
            this.gbEquipmentControls.Controls.Add(this.btnAddEquipment);
            this.gbEquipmentControls.Controls.Add(this.btnChangeEquipment);
            this.gbEquipmentControls.Location = new System.Drawing.Point(15, 218);
            this.gbEquipmentControls.Name = "gbEquipmentControls";
            this.gbEquipmentControls.Size = new System.Drawing.Size(180, 82);
            this.gbEquipmentControls.TabIndex = 8;
            this.gbEquipmentControls.TabStop = false;
            this.gbEquipmentControls.Text = "Equipment";
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveEquipment.Location = new System.Drawing.Point(6, 48);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(78, 23);
            this.btnRemoveEquipment.TabIndex = 8;
            this.btnRemoveEquipment.Text = "Remove";
            this.btnRemoveEquipment.UseVisualStyleBackColor = false;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // gbWeightControls
            // 
            this.gbWeightControls.BackColor = System.Drawing.Color.White;
            this.gbWeightControls.Controls.Add(this.btnChangeWeight);
            this.gbWeightControls.Location = new System.Drawing.Point(202, 218);
            this.gbWeightControls.Name = "gbWeightControls";
            this.gbWeightControls.Size = new System.Drawing.Size(180, 53);
            this.gbWeightControls.TabIndex = 9;
            this.gbWeightControls.TabStop = false;
            this.gbWeightControls.Text = "Weight";
            // 
            // btnChangeWeight
            // 
            this.btnChangeWeight.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChangeWeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeWeight.Location = new System.Drawing.Point(6, 19);
            this.btnChangeWeight.Name = "btnChangeWeight";
            this.btnChangeWeight.Size = new System.Drawing.Size(168, 23);
            this.btnChangeWeight.TabIndex = 7;
            this.btnChangeWeight.Text = "Change";
            this.btnChangeWeight.UseVisualStyleBackColor = false;
            this.btnChangeWeight.Click += new System.EventHandler(this.btnChangeWeight_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinish.Location = new System.Drawing.Point(208, 277);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(167, 23);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 310);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.gbWeightControls);
            this.Controls.Add(this.gbEquipmentControls);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EquipmentForm";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            this.gbEquipmentControls.ResumeLayout(false);
            this.gbWeightControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEquipment;
        private System.Windows.Forms.ListBox lbWeight;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.TextBox tbEquipment;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Button btnChangeEquipment;
        private System.Windows.Forms.GroupBox gbEquipmentControls;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.GroupBox gbWeightControls;
        private System.Windows.Forms.Button btnChangeWeight;
        private System.Windows.Forms.Button btnFinish;
    }
}