namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelGroups;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxCurrentGroupDescribtion = new System.Windows.Forms.RichTextBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelFullNameVal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelResidenceVal = new System.Windows.Forms.Label();
            this.labelBirthdayVal = new System.Windows.Forms.Label();
            this.labelAgeVal = new System.Windows.Forms.Label();
            this.labelGenderVal = new System.Windows.Forms.Label();
            this.labelResidence = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.lableFullName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBoxCurrentGroup = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            labelGroups = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGroups
            // 
            labelGroups.AutoSize = true;
            labelGroups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelGroups.ForeColor = System.Drawing.Color.Teal;
            labelGroups.Location = new System.Drawing.Point(17, 257);
            labelGroups.Name = "labelGroups";
            labelGroups.Size = new System.Drawing.Size(69, 18);
            labelGroups.TabIndex = 66;
            labelGroups.Text = "Groups:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(676, 7);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(130, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(676, 47);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(130, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 54);
            this.label1.TabIndex = 53;
            this.label1.Text = "Welcome to Halfway! Find the middle point of you and your friend!\r\nPlease enter y" +
    "our  facebook app id.\r\n You can use the id supplied in the README.md file ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBoxCurrentGroupDescribtion);
            this.tabPage1.Controls.Add(this.pictureBoxCurrentGroup);
            this.tabPage1.Controls.Add(labelGroups);
            this.tabPage1.Controls.Add(this.listBoxGroups);
            this.tabPage1.Controls.Add(this.labelFullNameVal);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCurrentGroupDescribtion
            // 
            this.richTextBoxCurrentGroupDescribtion.Location = new System.Drawing.Point(343, 275);
            this.richTextBoxCurrentGroupDescribtion.Name = "richTextBoxCurrentGroupDescribtion";
            this.richTextBoxCurrentGroupDescribtion.Size = new System.Drawing.Size(107, 112);
            this.richTextBoxCurrentGroupDescribtion.TabIndex = 68;
            this.richTextBoxCurrentGroupDescribtion.Text = "";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 18;
            this.listBoxGroups.Location = new System.Drawing.Point(17, 275);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(199, 112);
            this.listBoxGroups.TabIndex = 65;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // labelFullNameVal
            // 
            this.labelFullNameVal.AutoSize = true;
            this.labelFullNameVal.Location = new System.Drawing.Point(294, 131);
            this.labelFullNameVal.Name = "labelFullNameVal";
            this.labelFullNameVal.Size = new System.Drawing.Size(0, 18);
            this.labelFullNameVal.TabIndex = 64;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelResidenceVal, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelBirthdayVal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAgeVal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGenderVal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelResidence, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelBirthday, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lableFullName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelGender, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAge, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(131, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 100);
            this.tableLayoutPanel1.TabIndex = 63;
            // 
            // labelResidenceVal
            // 
            this.labelResidenceVal.AutoSize = true;
            this.labelResidenceVal.Location = new System.Drawing.Point(162, 80);
            this.labelResidenceVal.Name = "labelResidenceVal";
            this.labelResidenceVal.Size = new System.Drawing.Size(0, 18);
            this.labelResidenceVal.TabIndex = 65;
            // 
            // labelBirthdayVal
            // 
            this.labelBirthdayVal.AutoSize = true;
            this.labelBirthdayVal.Location = new System.Drawing.Point(162, 60);
            this.labelBirthdayVal.Name = "labelBirthdayVal";
            this.labelBirthdayVal.Size = new System.Drawing.Size(0, 18);
            this.labelBirthdayVal.TabIndex = 65;
            // 
            // labelAgeVal
            // 
            this.labelAgeVal.AutoSize = true;
            this.labelAgeVal.Location = new System.Drawing.Point(162, 40);
            this.labelAgeVal.Name = "labelAgeVal";
            this.labelAgeVal.Size = new System.Drawing.Size(0, 18);
            this.labelAgeVal.TabIndex = 65;
            // 
            // labelGenderVal
            // 
            this.labelGenderVal.AutoSize = true;
            this.labelGenderVal.Location = new System.Drawing.Point(162, 20);
            this.labelGenderVal.Name = "labelGenderVal";
            this.labelGenderVal.Size = new System.Drawing.Size(0, 18);
            this.labelGenderVal.TabIndex = 65;
            // 
            // labelResidence
            // 
            this.labelResidence.AutoSize = true;
            this.labelResidence.Location = new System.Drawing.Point(3, 80);
            this.labelResidence.Name = "labelResidence";
            this.labelResidence.Size = new System.Drawing.Size(82, 18);
            this.labelResidence.TabIndex = 65;
            this.labelResidence.Text = "Residence:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(3, 60);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(65, 18);
            this.labelBirthday.TabIndex = 64;
            this.labelBirthday.Text = "Birthday:";
            // 
            // lableFullName
            // 
            this.lableFullName.AutoSize = true;
            this.lableFullName.Location = new System.Drawing.Point(3, 0);
            this.lableFullName.Name = "lableFullName";
            this.lableFullName.Size = new System.Drawing.Size(52, 18);
            this.lableFullName.TabIndex = 61;
            this.lableFullName.Text = "Name:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(3, 20);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(61, 18);
            this.labelGender.TabIndex = 59;
            this.labelGender.Text = "Gender:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(3, 40);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 18);
            this.labelAge.TabIndex = 56;
            this.labelAge.Text = "Age:";
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(17, 82);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 24);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "342918918244277";
            this.textBoxAppID.TextChanged += new System.EventHandler(this.textBoxAppID_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBoxCurrentGroup
            // 
            this.pictureBoxCurrentGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCurrentGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCurrentGroup.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurrentGroup.InitialImage")));
            this.pictureBoxCurrentGroup.Location = new System.Drawing.Point(222, 275);
            this.pictureBoxCurrentGroup.Name = "pictureBoxCurrentGroup";
            this.pictureBoxCurrentGroup.Size = new System.Drawing.Size(115, 112);
            this.pictureBoxCurrentGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrentGroup.TabIndex = 67;
            this.pictureBoxCurrentGroup.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::BasicFacebookFeatures.Properties.Resources.unkown_profile_male;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(17, 131);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(108, 100);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halfway";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label lableFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelResidence;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelFullNameVal;
        private System.Windows.Forms.Label labelResidenceVal;
        private System.Windows.Forms.Label labelBirthdayVal;
        private System.Windows.Forms.Label labelAgeVal;
        private System.Windows.Forms.Label labelGenderVal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxCurrentGroup;
        private System.Windows.Forms.RichTextBox richTextBoxCurrentGroupDescribtion;
    }
}