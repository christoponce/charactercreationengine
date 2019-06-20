namespace CharacterCreatorGUI
{
    partial class CreatorStartupForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Location = new System.Drawing.Point(34, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(163, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Creation Engine!";
            // 
            // gbOptions
            // 
            this.gbOptions.BackColor = System.Drawing.Color.White;
            this.gbOptions.Controls.Add(this.rbOption2);
            this.gbOptions.Controls.Add(this.rbOption1);
            this.gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOptions.Location = new System.Drawing.Point(12, 30);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(206, 69);
            this.gbOptions.TabIndex = 2;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Select Option:";
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.BackColor = System.Drawing.Color.White;
            this.rbOption2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbOption2.Location = new System.Drawing.Point(6, 42);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(157, 17);
            this.rbOption2.TabIndex = 3;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "Open Existing Character File";
            this.rbOption2.UseVisualStyleBackColor = false;
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.BackColor = System.Drawing.Color.White;
            this.rbOption1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbOption1.Location = new System.Drawing.Point(6, 19);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(129, 17);
            this.rbOption1.TabIndex = 0;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "Create New Character";
            this.rbOption1.UseVisualStyleBackColor = false;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.White;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Location = new System.Drawing.Point(11, 105);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(206, 34);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // CreatorStartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(229, 151);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.lblWelcome);
            this.Name = "CreatorStartupForm";
            this.Text = "Welcome!";
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.Button btnGo;
    }
}