namespace CharacterCreatorGUI
{
    partial class MainCreatorForm
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.gbRacial = new System.Windows.Forms.GroupBox();
            this.cbWings = new System.Windows.Forms.ComboBox();
            this.lblWings = new System.Windows.Forms.Label();
            this.cbDiet = new System.Windows.Forms.ComboBox();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.cbTail = new System.Windows.Forms.ComboBox();
            this.cbCreatureType = new System.Windows.Forms.ComboBox();
            this.lblDiet = new System.Windows.Forms.Label();
            this.lblCreatureType = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubrace = new System.Windows.Forms.Label();
            this.tbSubrace = new System.Windows.Forms.TextBox();
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.cbBackground = new System.Windows.Forms.ComboBox();
            this.cbAlignment = new System.Windows.Forms.ComboBox();
            this.cbCombatClass = new System.Windows.Forms.ComboBox();
            this.lblBackground = new System.Windows.Forms.Label();
            this.lblAlignment = new System.Windows.Forms.Label();
            this.cbRelativeSize = new System.Windows.Forms.ComboBox();
            this.lblCombatClass = new System.Windows.Forms.Label();
            this.lblRelativeSize = new System.Windows.Forms.Label();
            this.tbGUID = new System.Windows.Forms.TextBox();
            this.gbCreatureGUID = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useRandomSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRaceDescription = new System.Windows.Forms.GroupBox();
            this.rtbRaceDescription = new System.Windows.Forms.RichTextBox();
            this.gbPersonal.SuspendLayout();
            this.gbRacial.SuspendLayout();
            this.gbMisc.SuspendLayout();
            this.gbCreatureGUID.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbRaceDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbFirstName.Location = new System.Drawing.Point(72, 22);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(120, 20);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.White;
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbSurname.Location = new System.Drawing.Point(72, 48);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(120, 20);
            this.tbSurname.TabIndex = 3;
            this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSurname.Location = new System.Drawing.Point(6, 51);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname:";
            // 
            // gbPersonal
            // 
            this.gbPersonal.Controls.Add(this.cbGender);
            this.gbPersonal.Controls.Add(this.label2);
            this.gbPersonal.Controls.Add(this.tbWeight);
            this.gbPersonal.Controls.Add(this.lblGender);
            this.gbPersonal.Controls.Add(this.lblHeight);
            this.gbPersonal.Controls.Add(this.tbHeight);
            this.gbPersonal.Controls.Add(this.label1);
            this.gbPersonal.Controls.Add(this.tbAge);
            this.gbPersonal.Controls.Add(this.lblFirstName);
            this.gbPersonal.Controls.Add(this.lblSurname);
            this.gbPersonal.Controls.Add(this.tbFirstName);
            this.gbPersonal.Controls.Add(this.tbSurname);
            this.gbPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonal.Location = new System.Drawing.Point(12, 108);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(423, 104);
            this.gbPersonal.TabIndex = 6;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Personal Information";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.White;
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(293, 20);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(120, 21);
            this.cbGender.TabIndex = 14;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(218, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Weight (lbs.):";
            // 
            // tbWeight
            // 
            this.tbWeight.BackColor = System.Drawing.Color.White;
            this.tbWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbWeight.Location = new System.Drawing.Point(293, 73);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(120, 20);
            this.tbWeight.TabIndex = 12;
            this.tbWeight.TextChanged += new System.EventHandler(this.tbWeight_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblGender.Location = new System.Drawing.Point(218, 24);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblHeight.Location = new System.Drawing.Point(218, 51);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(61, 13);
            this.lblHeight.TabIndex = 11;
            this.lblHeight.Text = "Height (in.):";
            // 
            // tbHeight
            // 
            this.tbHeight.BackColor = System.Drawing.Color.White;
            this.tbHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbHeight.Location = new System.Drawing.Point(293, 48);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(120, 20);
            this.tbHeight.TabIndex = 9;
            this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Age:";
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.Color.White;
            this.tbAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbAge.Location = new System.Drawing.Point(72, 75);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(120, 20);
            this.tbAge.TabIndex = 6;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // gbRacial
            // 
            this.gbRacial.Controls.Add(this.cbWings);
            this.gbRacial.Controls.Add(this.lblWings);
            this.gbRacial.Controls.Add(this.cbDiet);
            this.gbRacial.Controls.Add(this.cbRace);
            this.gbRacial.Controls.Add(this.cbTail);
            this.gbRacial.Controls.Add(this.cbCreatureType);
            this.gbRacial.Controls.Add(this.lblDiet);
            this.gbRacial.Controls.Add(this.lblCreatureType);
            this.gbRacial.Controls.Add(this.lblRace);
            this.gbRacial.Controls.Add(this.label5);
            this.gbRacial.Controls.Add(this.lblSubrace);
            this.gbRacial.Controls.Add(this.tbSubrace);
            this.gbRacial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRacial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRacial.Location = new System.Drawing.Point(12, 218);
            this.gbRacial.Name = "gbRacial";
            this.gbRacial.Size = new System.Drawing.Size(423, 104);
            this.gbRacial.TabIndex = 7;
            this.gbRacial.TabStop = false;
            this.gbRacial.Text = "Racial Information";
            // 
            // cbWings
            // 
            this.cbWings.BackColor = System.Drawing.Color.White;
            this.cbWings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbWings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbWings.FormattingEnabled = true;
            this.cbWings.Location = new System.Drawing.Point(293, 73);
            this.cbWings.Name = "cbWings";
            this.cbWings.Size = new System.Drawing.Size(120, 21);
            this.cbWings.TabIndex = 18;
            // 
            // lblWings
            // 
            this.lblWings.AutoSize = true;
            this.lblWings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblWings.Location = new System.Drawing.Point(227, 78);
            this.lblWings.Name = "lblWings";
            this.lblWings.Size = new System.Drawing.Size(40, 13);
            this.lblWings.TabIndex = 17;
            this.lblWings.Text = "Wings:";
            // 
            // cbDiet
            // 
            this.cbDiet.BackColor = System.Drawing.Color.White;
            this.cbDiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbDiet.FormattingEnabled = true;
            this.cbDiet.Location = new System.Drawing.Point(72, 73);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(120, 21);
            this.cbDiet.TabIndex = 15;
            this.cbDiet.SelectedIndexChanged += new System.EventHandler(this.cbDiet_SelectedIndexChanged);
            // 
            // cbRace
            // 
            this.cbRace.BackColor = System.Drawing.Color.White;
            this.cbRace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Location = new System.Drawing.Point(72, 18);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(120, 21);
            this.cbRace.TabIndex = 15;
            this.cbRace.SelectedIndexChanged += new System.EventHandler(this.cbRace_SelectedIndexChanged);
            // 
            // cbTail
            // 
            this.cbTail.BackColor = System.Drawing.Color.White;
            this.cbTail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbTail.FormattingEnabled = true;
            this.cbTail.Location = new System.Drawing.Point(293, 44);
            this.cbTail.Name = "cbTail";
            this.cbTail.Size = new System.Drawing.Size(120, 21);
            this.cbTail.TabIndex = 16;
            this.cbTail.SelectedIndexChanged += new System.EventHandler(this.cbTail_SelectedIndexChanged);
            // 
            // cbCreatureType
            // 
            this.cbCreatureType.BackColor = System.Drawing.Color.White;
            this.cbCreatureType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCreatureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbCreatureType.FormattingEnabled = true;
            this.cbCreatureType.Location = new System.Drawing.Point(72, 46);
            this.cbCreatureType.Name = "cbCreatureType";
            this.cbCreatureType.Size = new System.Drawing.Size(120, 21);
            this.cbCreatureType.TabIndex = 14;
            this.cbCreatureType.SelectedIndexChanged += new System.EventHandler(this.cbCreatureType_SelectedIndexChanged);
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDiet.Location = new System.Drawing.Point(6, 78);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(29, 13);
            this.lblDiet.TabIndex = 7;
            this.lblDiet.Text = "Diet:";
            // 
            // lblCreatureType
            // 
            this.lblCreatureType.AutoSize = true;
            this.lblCreatureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCreatureType.Location = new System.Drawing.Point(6, 51);
            this.lblCreatureType.Name = "lblCreatureType";
            this.lblCreatureType.Size = new System.Drawing.Size(34, 13);
            this.lblCreatureType.TabIndex = 10;
            this.lblCreatureType.Text = "Type:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(6, 23);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(36, 13);
            this.lblRace.TabIndex = 4;
            this.lblRace.Text = "Race:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(227, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tail:";
            // 
            // lblSubrace
            // 
            this.lblSubrace.AutoSize = true;
            this.lblSubrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSubrace.Location = new System.Drawing.Point(227, 21);
            this.lblSubrace.Name = "lblSubrace";
            this.lblSubrace.Size = new System.Drawing.Size(50, 13);
            this.lblSubrace.TabIndex = 5;
            this.lblSubrace.Text = "Subrace:";
            // 
            // tbSubrace
            // 
            this.tbSubrace.BackColor = System.Drawing.Color.White;
            this.tbSubrace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSubrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbSubrace.Location = new System.Drawing.Point(293, 18);
            this.tbSubrace.Name = "tbSubrace";
            this.tbSubrace.Size = new System.Drawing.Size(120, 20);
            this.tbSubrace.TabIndex = 3;
            this.tbSubrace.TextChanged += new System.EventHandler(this.tbSubrace_TextChanged);
            // 
            // gbMisc
            // 
            this.gbMisc.Controls.Add(this.cbBackground);
            this.gbMisc.Controls.Add(this.cbAlignment);
            this.gbMisc.Controls.Add(this.cbCombatClass);
            this.gbMisc.Controls.Add(this.lblBackground);
            this.gbMisc.Controls.Add(this.lblAlignment);
            this.gbMisc.Controls.Add(this.cbRelativeSize);
            this.gbMisc.Controls.Add(this.lblCombatClass);
            this.gbMisc.Controls.Add(this.lblRelativeSize);
            this.gbMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMisc.Location = new System.Drawing.Point(12, 328);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(423, 80);
            this.gbMisc.TabIndex = 15;
            this.gbMisc.TabStop = false;
            this.gbMisc.Text = "Misc Information";
            // 
            // cbBackground
            // 
            this.cbBackground.BackColor = System.Drawing.Color.White;
            this.cbBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbBackground.FormattingEnabled = true;
            this.cbBackground.Location = new System.Drawing.Point(293, 20);
            this.cbBackground.Name = "cbBackground";
            this.cbBackground.Size = new System.Drawing.Size(120, 21);
            this.cbBackground.TabIndex = 14;
            this.cbBackground.SelectedIndexChanged += new System.EventHandler(this.cbBackground_SelectedIndexChanged);
            // 
            // cbAlignment
            // 
            this.cbAlignment.BackColor = System.Drawing.Color.White;
            this.cbAlignment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAlignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbAlignment.FormattingEnabled = true;
            this.cbAlignment.Location = new System.Drawing.Point(293, 48);
            this.cbAlignment.Name = "cbAlignment";
            this.cbAlignment.Size = new System.Drawing.Size(120, 21);
            this.cbAlignment.TabIndex = 17;
            this.cbAlignment.SelectedIndexChanged += new System.EventHandler(this.cbAlignment_SelectedIndexChanged);
            // 
            // cbCombatClass
            // 
            this.cbCombatClass.BackColor = System.Drawing.Color.White;
            this.cbCombatClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCombatClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbCombatClass.FormattingEnabled = true;
            this.cbCombatClass.Location = new System.Drawing.Point(72, 20);
            this.cbCombatClass.Name = "cbCombatClass";
            this.cbCombatClass.Size = new System.Drawing.Size(120, 21);
            this.cbCombatClass.TabIndex = 15;
            this.cbCombatClass.SelectedIndexChanged += new System.EventHandler(this.cbCombatClass_SelectedIndexChanged);
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBackground.Location = new System.Drawing.Point(219, 25);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(68, 13);
            this.lblBackground.TabIndex = 10;
            this.lblBackground.Text = "Background:";
            // 
            // lblAlignment
            // 
            this.lblAlignment.AutoSize = true;
            this.lblAlignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAlignment.Location = new System.Drawing.Point(219, 51);
            this.lblAlignment.Name = "lblAlignment";
            this.lblAlignment.Size = new System.Drawing.Size(56, 13);
            this.lblAlignment.TabIndex = 11;
            this.lblAlignment.Text = "Alignment:";
            // 
            // cbRelativeSize
            // 
            this.cbRelativeSize.BackColor = System.Drawing.Color.White;
            this.cbRelativeSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRelativeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbRelativeSize.FormattingEnabled = true;
            this.cbRelativeSize.Location = new System.Drawing.Point(72, 46);
            this.cbRelativeSize.Name = "cbRelativeSize";
            this.cbRelativeSize.Size = new System.Drawing.Size(120, 21);
            this.cbRelativeSize.TabIndex = 16;
            this.cbRelativeSize.SelectedIndexChanged += new System.EventHandler(this.cbRelativeSize_SelectedIndexChanged);
            // 
            // lblCombatClass
            // 
            this.lblCombatClass.AutoSize = true;
            this.lblCombatClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombatClass.Location = new System.Drawing.Point(6, 25);
            this.lblCombatClass.Name = "lblCombatClass";
            this.lblCombatClass.Size = new System.Drawing.Size(35, 13);
            this.lblCombatClass.TabIndex = 4;
            this.lblCombatClass.Text = "Class:";
            // 
            // lblRelativeSize
            // 
            this.lblRelativeSize.AutoSize = true;
            this.lblRelativeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblRelativeSize.Location = new System.Drawing.Point(6, 51);
            this.lblRelativeSize.Name = "lblRelativeSize";
            this.lblRelativeSize.Size = new System.Drawing.Size(30, 13);
            this.lblRelativeSize.TabIndex = 5;
            this.lblRelativeSize.Text = "Size:";
            // 
            // tbGUID
            // 
            this.tbGUID.BackColor = System.Drawing.Color.White;
            this.tbGUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbGUID.Location = new System.Drawing.Point(9, 29);
            this.tbGUID.MaxLength = 36;
            this.tbGUID.Name = "tbGUID";
            this.tbGUID.ReadOnly = true;
            this.tbGUID.Size = new System.Drawing.Size(404, 20);
            this.tbGUID.TabIndex = 16;
            // 
            // gbCreatureGUID
            // 
            this.gbCreatureGUID.Controls.Add(this.tbGUID);
            this.gbCreatureGUID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCreatureGUID.Location = new System.Drawing.Point(12, 27);
            this.gbCreatureGUID.Name = "gbCreatureGUID";
            this.gbCreatureGUID.Size = new System.Drawing.Size(423, 75);
            this.gbCreatureGUID.TabIndex = 18;
            this.gbCreatureGUID.TabStop = false;
            this.gbCreatureGUID.Text = "Unique ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildCharacterToolStripMenuItem,
            this.characterStatsToolStripMenuItem,
            this.useRandomSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editToolStripMenuItem.Text = "Options";
            // 
            // buildCharacterToolStripMenuItem
            // 
            this.buildCharacterToolStripMenuItem.Name = "buildCharacterToolStripMenuItem";
            this.buildCharacterToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.buildCharacterToolStripMenuItem.Text = "&Build Character";
            this.buildCharacterToolStripMenuItem.Click += new System.EventHandler(this.buildCharacterToolStripMenuItem_Click);
            // 
            // characterStatsToolStripMenuItem
            // 
            this.characterStatsToolStripMenuItem.Name = "characterStatsToolStripMenuItem";
            this.characterStatsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.characterStatsToolStripMenuItem.Text = "Character &Stats";
            this.characterStatsToolStripMenuItem.Click += new System.EventHandler(this.characterStatsToolStripMenuItem_Click);
            // 
            // useRandomSettingsToolStripMenuItem
            // 
            this.useRandomSettingsToolStripMenuItem.Name = "useRandomSettingsToolStripMenuItem";
            this.useRandomSettingsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.useRandomSettingsToolStripMenuItem.Text = "Use &Random Settings";
            this.useRandomSettingsToolStripMenuItem.Click += new System.EventHandler(this.useRandomSettingsToolStripMenuItem_Click);
            // 
            // gbRaceDescription
            // 
            this.gbRaceDescription.Controls.Add(this.rtbRaceDescription);
            this.gbRaceDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRaceDescription.Location = new System.Drawing.Point(12, 415);
            this.gbRaceDescription.Name = "gbRaceDescription";
            this.gbRaceDescription.Size = new System.Drawing.Size(421, 118);
            this.gbRaceDescription.TabIndex = 24;
            this.gbRaceDescription.TabStop = false;
            this.gbRaceDescription.Text = "Race Description:";
            // 
            // rtbRaceDescription
            // 
            this.rtbRaceDescription.BackColor = System.Drawing.Color.White;
            this.rtbRaceDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRaceDescription.Location = new System.Drawing.Point(9, 19);
            this.rtbRaceDescription.Name = "rtbRaceDescription";
            this.rtbRaceDescription.ReadOnly = true;
            this.rtbRaceDescription.Size = new System.Drawing.Size(404, 93);
            this.rtbRaceDescription.TabIndex = 0;
            this.rtbRaceDescription.Text = "";
            // 
            // MainCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 545);
            this.Controls.Add(this.gbRaceDescription);
            this.Controls.Add(this.gbCreatureGUID);
            this.Controls.Add(this.gbMisc);
            this.Controls.Add(this.gbRacial);
            this.Controls.Add(this.gbPersonal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainCreatorForm";
            this.Text = "Character Creation Engine";
            this.Load += new System.EventHandler(this.MainCreatorForm_Load);
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            this.gbRacial.ResumeLayout(false);
            this.gbRacial.PerformLayout();
            this.gbMisc.ResumeLayout(false);
            this.gbMisc.PerformLayout();
            this.gbCreatureGUID.ResumeLayout(false);
            this.gbCreatureGUID.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbRaceDescription.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.GroupBox gbRacial;
        private System.Windows.Forms.ComboBox cbCreatureType;
        private System.Windows.Forms.Label lblCreatureType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiet;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblSubrace;
        private System.Windows.Forms.TextBox tbSubrace;
        private System.Windows.Forms.ComboBox cbDiet;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.ComboBox cbTail;
        private System.Windows.Forms.GroupBox gbMisc;
        private System.Windows.Forms.ComboBox cbBackground;
        private System.Windows.Forms.ComboBox cbAlignment;
        private System.Windows.Forms.ComboBox cbCombatClass;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.Label lblAlignment;
        private System.Windows.Forms.ComboBox cbRelativeSize;
        private System.Windows.Forms.Label lblCombatClass;
        private System.Windows.Forms.Label lblRelativeSize;
        private System.Windows.Forms.TextBox tbGUID;
        private System.Windows.Forms.GroupBox gbCreatureGUID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbWings;
        private System.Windows.Forms.Label lblWings;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useRandomSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbRaceDescription;
        private System.Windows.Forms.RichTextBox rtbRaceDescription;
    }
}

