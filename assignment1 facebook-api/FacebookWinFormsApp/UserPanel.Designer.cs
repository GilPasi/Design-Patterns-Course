namespace BasicFacebookFeatures
{
    partial class UserPanel
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
            System.Windows.Forms.Label labelAlbums;
            System.Windows.Forms.Label labelPages;
            System.Windows.Forms.Label labelGroups;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.pictureBoxCurrentGroup = new System.Windows.Forms.PictureBox();
            this.richTextBoxCurrentGroupDescription = new System.Windows.Forms.RichTextBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelPicturePosition = new System.Windows.Forms.Label();
            this.buttonPrevPicture = new System.Windows.Forms.Button();
            this.buttonNextPicture = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxCurrentAlbum = new System.Windows.Forms.PictureBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.richTextBoxCurrentPageDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBoxCurrentPage = new System.Windows.Forms.PictureBox();
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            labelAlbums = new System.Windows.Forms.Label();
            labelPages = new System.Windows.Forms.Label();
            labelGroups = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlbums
            // 
            labelAlbums.AutoSize = true;
            labelAlbums.FlatStyle = System.Windows.Forms.FlatStyle.System;
            labelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAlbums.ForeColor = System.Drawing.Color.Teal;
            labelAlbums.Location = new System.Drawing.Point(25, 395);
            labelAlbums.Name = "labelAlbums";
            labelAlbums.Size = new System.Drawing.Size(68, 18);
            labelAlbums.TabIndex = 91;
            labelAlbums.Text = "Albums:";
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.FlatStyle = System.Windows.Forms.FlatStyle.System;
            labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPages.ForeColor = System.Drawing.Color.Teal;
            labelPages.Location = new System.Drawing.Point(25, 257);
            labelPages.Name = "labelPages";
            labelPages.Size = new System.Drawing.Size(105, 18);
            labelPages.TabIndex = 87;
            labelPages.Text = "Liked Pages:";
            // 
            // labelGroups
            // 
            labelGroups.AutoSize = true;
            labelGroups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelGroups.ForeColor = System.Drawing.Color.Teal;
            labelGroups.Location = new System.Drawing.Point(16, 123);
            labelGroups.Name = "labelGroups";
            labelGroups.Size = new System.Drawing.Size(69, 18);
            labelGroups.TabIndex = 83;
            labelGroups.Text = "Groups:";
            // 
            // pictureBoxCurrentGroup
            // 
            this.pictureBoxCurrentGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCurrentGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCurrentGroup.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurrentGroup.InitialImage")));
            this.pictureBoxCurrentGroup.Location = new System.Drawing.Point(233, 144);
            this.pictureBoxCurrentGroup.Name = "pictureBoxCurrentGroup";
            this.pictureBoxCurrentGroup.Size = new System.Drawing.Size(115, 112);
            this.pictureBoxCurrentGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrentGroup.TabIndex = 84;
            this.pictureBoxCurrentGroup.TabStop = false;
            // 
            // richTextBoxCurrentGroupDescription
            // 
            this.richTextBoxCurrentGroupDescription.Location = new System.Drawing.Point(354, 144);
            this.richTextBoxCurrentGroupDescription.Name = "richTextBoxCurrentGroupDescription";
            this.richTextBoxCurrentGroupDescription.Size = new System.Drawing.Size(107, 112);
            this.richTextBoxCurrentGroupDescription.TabIndex = 85;
            this.richTextBoxCurrentGroupDescription.Text = "";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(19, 144);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(208, 121);
            this.listBoxGroups.TabIndex = 82;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // labelPicturePosition
            // 
            this.labelPicturePosition.AutoSize = true;
            this.labelPicturePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicturePosition.Location = new System.Drawing.Point(397, 418);
            this.labelPicturePosition.Name = "labelPicturePosition";
            this.labelPicturePosition.Size = new System.Drawing.Size(25, 18);
            this.labelPicturePosition.TabIndex = 95;
            this.labelPicturePosition.Text = "-/-";
            // 
            // buttonPrevPicture
            // 
            this.buttonPrevPicture.Location = new System.Drawing.Point(354, 446);
            this.buttonPrevPicture.Name = "buttonPrevPicture";
            this.buttonPrevPicture.Size = new System.Drawing.Size(53, 27);
            this.buttonPrevPicture.TabIndex = 94;
            this.buttonPrevPicture.Text = "Back";
            this.buttonPrevPicture.UseVisualStyleBackColor = true;
            this.buttonPrevPicture.Click += new System.EventHandler(this.buttonPrevPicture_Click);
            // 
            // buttonNextPicture
            // 
            this.buttonNextPicture.Location = new System.Drawing.Point(408, 446);
            this.buttonNextPicture.Name = "buttonNextPicture";
            this.buttonNextPicture.Size = new System.Drawing.Size(53, 27);
            this.buttonNextPicture.TabIndex = 93;
            this.buttonNextPicture.Text = "Next";
            this.buttonNextPicture.UseVisualStyleBackColor = true;
            this.buttonNextPicture.Click += new System.EventHandler(this.buttonNextPicture_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(19, 418);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(208, 121);
            this.listBoxAlbums.TabIndex = 90;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxCurrentAlbum
            // 
            this.pictureBoxCurrentAlbum.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCurrentAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCurrentAlbum.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurrentAlbum.InitialImage")));
            this.pictureBoxCurrentAlbum.Location = new System.Drawing.Point(233, 418);
            this.pictureBoxCurrentAlbum.Name = "pictureBoxCurrentAlbum";
            this.pictureBoxCurrentAlbum.Size = new System.Drawing.Size(115, 112);
            this.pictureBoxCurrentAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrentAlbum.TabIndex = 92;
            this.pictureBoxCurrentAlbum.TabStop = false;
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(19, 278);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(208, 121);
            this.listBoxPages.TabIndex = 86;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // richTextBoxCurrentPageDescription
            // 
            this.richTextBoxCurrentPageDescription.Location = new System.Drawing.Point(354, 278);
            this.richTextBoxCurrentPageDescription.Name = "richTextBoxCurrentPageDescription";
            this.richTextBoxCurrentPageDescription.Size = new System.Drawing.Size(107, 112);
            this.richTextBoxCurrentPageDescription.TabIndex = 89;
            this.richTextBoxCurrentPageDescription.Text = "";
            // 
            // pictureBoxCurrentPage
            // 
            this.pictureBoxCurrentPage.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCurrentPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCurrentPage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurrentPage.InitialImage")));
            this.pictureBoxCurrentPage.Location = new System.Drawing.Point(233, 278);
            this.pictureBoxCurrentPage.Name = "pictureBoxCurrentPage";
            this.pictureBoxCurrentPage.Size = new System.Drawing.Size(115, 112);
            this.pictureBoxCurrentPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrentPage.TabIndex = 88;
            this.pictureBoxCurrentPage.TabStop = false;
            // 
            // labelFullNameVal
            // 
            this.labelFullNameVal.AutoSize = true;
            this.labelFullNameVal.Location = new System.Drawing.Point(277, 3);
            this.labelFullNameVal.Name = "labelFullNameVal";
            this.labelFullNameVal.Size = new System.Drawing.Size(0, 13);
            this.labelFullNameVal.TabIndex = 81;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.0411F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.9589F));
            this.tableLayoutPanel1.Controls.Add(this.labelResidenceVal, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelBirthdayVal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAgeVal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGenderVal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelResidence, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelBirthday, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lableFullName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelGender, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAge, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(142, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 100);
            this.tableLayoutPanel1.TabIndex = 80;
            // 
            // labelResidenceVal
            // 
            this.labelResidenceVal.AutoSize = true;
            this.labelResidenceVal.Location = new System.Drawing.Point(93, 80);
            this.labelResidenceVal.Name = "labelResidenceVal";
            this.labelResidenceVal.Size = new System.Drawing.Size(0, 13);
            this.labelResidenceVal.TabIndex = 65;
            // 
            // labelBirthdayVal
            // 
            this.labelBirthdayVal.AutoSize = true;
            this.labelBirthdayVal.Location = new System.Drawing.Point(93, 60);
            this.labelBirthdayVal.Name = "labelBirthdayVal";
            this.labelBirthdayVal.Size = new System.Drawing.Size(0, 13);
            this.labelBirthdayVal.TabIndex = 65;
            // 
            // labelAgeVal
            // 
            this.labelAgeVal.AutoSize = true;
            this.labelAgeVal.Location = new System.Drawing.Point(93, 40);
            this.labelAgeVal.Name = "labelAgeVal";
            this.labelAgeVal.Size = new System.Drawing.Size(0, 13);
            this.labelAgeVal.TabIndex = 65;
            // 
            // labelGenderVal
            // 
            this.labelGenderVal.AutoSize = true;
            this.labelGenderVal.Location = new System.Drawing.Point(93, 20);
            this.labelGenderVal.Name = "labelGenderVal";
            this.labelGenderVal.Size = new System.Drawing.Size(0, 13);
            this.labelGenderVal.TabIndex = 65;
            // 
            // labelResidence
            // 
            this.labelResidence.AutoSize = true;
            this.labelResidence.Location = new System.Drawing.Point(3, 80);
            this.labelResidence.Name = "labelResidence";
            this.labelResidence.Size = new System.Drawing.Size(61, 13);
            this.labelResidence.TabIndex = 65;
            this.labelResidence.Text = "Residence:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(3, 60);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(48, 13);
            this.labelBirthday.TabIndex = 64;
            this.labelBirthday.Text = "Birthday:";
            // 
            // lableFullName
            // 
            this.lableFullName.AutoSize = true;
            this.lableFullName.Location = new System.Drawing.Point(3, 0);
            this.lableFullName.Name = "lableFullName";
            this.lableFullName.Size = new System.Drawing.Size(38, 13);
            this.lableFullName.TabIndex = 61;
            this.lableFullName.Text = "Name:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(3, 20);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(45, 13);
            this.labelGender.TabIndex = 59;
            this.labelGender.Text = "Gender:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(3, 40);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 56;
            this.labelAge.Text = "Age:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::BasicFacebookFeatures.Properties.Resources.unkown_profile_male;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(28, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(108, 100);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 79;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(390, 23);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(54, 53);
            this.buttonClear.TabIndex = 96;
            this.buttonClear.Text = "Clear User";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // UserPanel
            // 
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxCurrentGroup);
            this.Controls.Add(this.richTextBoxCurrentGroupDescription);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.labelPicturePosition);
            this.Controls.Add(this.buttonPrevPicture);
            this.Controls.Add(this.buttonNextPicture);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(labelAlbums);
            this.Controls.Add(this.pictureBoxCurrentAlbum);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(labelPages);
            this.Controls.Add(this.richTextBoxCurrentPageDescription);
            this.Controls.Add(this.pictureBoxCurrentPage);
            this.Controls.Add(labelGroups);
            this.Controls.Add(this.labelFullNameVal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(465, 553);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCurrentGroup;
        private System.Windows.Forms.RichTextBox richTextBoxCurrentGroupDescription;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelPicturePosition;
        private System.Windows.Forms.Button buttonPrevPicture;
        private System.Windows.Forms.Button buttonNextPicture;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxCurrentAlbum;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.RichTextBox richTextBoxCurrentPageDescription;
        private System.Windows.Forms.PictureBox pictureBoxCurrentPage;
        private System.Windows.Forms.Label labelFullNameVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelResidenceVal;
        private System.Windows.Forms.Label labelBirthdayVal;
        private System.Windows.Forms.Label labelAgeVal;
        private System.Windows.Forms.Label labelGenderVal;
        private System.Windows.Forms.Label labelResidence;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label lableFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonClear;
    }
}
