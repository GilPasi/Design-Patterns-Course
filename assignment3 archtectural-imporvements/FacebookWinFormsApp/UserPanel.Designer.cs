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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelAlbums;
            System.Windows.Forms.Label labelPages;
            System.Windows.Forms.Label labelGroups;
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPicturePosition = new System.Windows.Forms.Label();
            this.buttonPrevPicture = new System.Windows.Forms.Button();
            this.buttonNextPicture = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFullNameVal = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.imageThumbPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelCard = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            labelAlbums = new System.Windows.Forms.Label();
            labelPages = new System.Windows.Forms.Label();
            labelGroups = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageThumbPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCardBindingSource)).BeginInit();
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
            // listBoxGroups
            // 
            this.listBoxGroups.DataSource = this.groupBindingSource;
            this.listBoxGroups.Enabled = false;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(19, 144);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(208, 121);
            this.listBoxGroups.TabIndex = 82;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
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
            this.buttonPrevPicture.Enabled = false;
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
            this.buttonNextPicture.Enabled = false;
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
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.Enabled = false;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(19, 418);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(208, 121);
            this.listBoxAlbums.TabIndex = 90;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // listBoxPages
            // 
            this.listBoxPages.DataSource = this.pageBindingSource;
            this.listBoxPages.DisplayMember = "Name";
            this.listBoxPages.Enabled = false;
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(19, 278);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(208, 121);
            this.listBoxPages.TabIndex = 86;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // labelFullNameVal
            // 
            this.labelFullNameVal.AutoSize = true;
            this.labelFullNameVal.Location = new System.Drawing.Point(277, 3);
            this.labelFullNameVal.Name = "labelFullNameVal";
            this.labelFullNameVal.Size = new System.Drawing.Size(0, 13);
            this.labelFullNameVal.TabIndex = 81;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::BasicFacebookFeatures.Properties.Resources.unkown_profile_male;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(19, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(123, 117);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 79;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(390, 57);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(54, 46);
            this.buttonClear.TabIndex = 96;
            this.buttonClear.Text = "Clear User";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(390, 2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(54, 49);
            this.buttonLoad.TabIndex = 97;
            this.buttonLoad.Text = "Load User";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // imageThumbPictureBox
            // 
            this.imageThumbPictureBox.BackColor = System.Drawing.Color.SlateGray;
            this.imageThumbPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageThumb", true));
            this.imageThumbPictureBox.Location = new System.Drawing.Point(233, 418);
            this.imageThumbPictureBox.Name = "imageThumbPictureBox";
            this.imageThumbPictureBox.Size = new System.Drawing.Size(115, 111);
            this.imageThumbPictureBox.TabIndex = 107;
            this.imageThumbPictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(354, 278);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 109);
            this.descriptionTextBox.TabIndex = 108;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BackColor = System.Drawing.Color.SlateGray;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(233, 278);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(115, 109);
            this.imageNormalPictureBox.TabIndex = 110;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(354, 144);
            this.descriptionTextBox1.Multiline = true;
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(100, 110);
            this.descriptionTextBox1.TabIndex = 111;
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(233, 144);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(115, 110);
            this.imageNormalPictureBox1.TabIndex = 113;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // userCardBindingSource
            // 
            this.userCardBindingSource.DataSource = typeof(BasicFacebookFeatures.UserCardTable);
            // 
            // tableLayoutPanelCard
            // 
            this.tableLayoutPanelCard.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelCard.ColumnCount = 2;
            this.tableLayoutPanelCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCard.Location = new System.Drawing.Point(148, 21);
            this.tableLayoutPanelCard.Name = "tableLayoutPanelCard";
            this.tableLayoutPanelCard.RowCount = 1;
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCard.Size = new System.Drawing.Size(236, 99);
            this.tableLayoutPanelCard.TabIndex = 114;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NameLabel.ForeColor = System.Drawing.Color.Teal;
            this.NameLabel.Location = new System.Drawing.Point(148, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // UserPanel
            // 
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.tableLayoutPanelCard);
            this.Controls.Add(this.descriptionTextBox1);
            this.Controls.Add(this.imageNormalPictureBox1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(this.imageThumbPictureBox);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.labelPicturePosition);
            this.Controls.Add(this.buttonPrevPicture);
            this.Controls.Add(this.buttonNextPicture);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(labelAlbums);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(labelPages);
            this.Controls.Add(labelGroups);
            this.Controls.Add(this.labelFullNameVal);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(481, 621);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageThumbPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelPicturePosition;
        private System.Windows.Forms.Button buttonPrevPicture;
        private System.Windows.Forms.Button buttonNextPicture;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Label labelFullNameVal;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageThumbPictureBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userCardBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCard;
        private System.Windows.Forms.Label NameLabel;
    }
}
