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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFindHalfway = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.userPanel1 = new BasicFacebookFeatures.UserPanel();
            this.userPanel2 = new BasicFacebookFeatures.UserPanel();
            this.labelFullNameVal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelAvgAge = new System.Windows.Forms.Label();
            this.labelAvgAgeVal = new System.Windows.Forms.Label();
            this.labelMutualIntersts = new System.Windows.Forms.Label();
            this.labelLocationMidPoint = new System.Windows.Forms.Label();
            this.listBoxMutualGroups = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLocationMidPointVal = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 108);
            this.label1.TabIndex = 53;
            this.label1.Text = "Welcome to Halfway!\r\n Find the middle point of \r\nyou and your friend!\r\nPlease ent" +
    "er your  facebook app id.\r\n You can use the id \r\nsupplied in the README.md file " +
    "";
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
            this.tabPage1.Controls.Add(this.labelLocationMidPointVal);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBoxMutualGroups);
            this.tabPage1.Controls.Add(this.labelLocationMidPoint);
            this.tabPage1.Controls.Add(this.labelMutualIntersts);
            this.tabPage1.Controls.Add(this.labelAvgAgeVal);
            this.tabPage1.Controls.Add(this.labelAvgAge);
            this.tabPage1.Controls.Add(this.buttonFindHalfway);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Controls.Add(this.userPanel1);
            this.tabPage1.Controls.Add(this.userPanel2);
            this.tabPage1.Controls.Add(this.labelFullNameVal);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFindHalfway
            // 
            this.buttonFindHalfway.Location = new System.Drawing.Point(485, 358);
            this.buttonFindHalfway.Name = "buttonFindHalfway";
            this.buttonFindHalfway.Size = new System.Drawing.Size(241, 32);
            this.buttonFindHalfway.TabIndex = 103;
            this.buttonFindHalfway.Text = "Meet Halfway!";
            this.buttonFindHalfway.UseVisualStyleBackColor = true;
            this.buttonFindHalfway.Click += new System.EventHandler(this.buttonFindHalfway_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(485, 249);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(241, 32);
            this.buttonLogout.TabIndex = 102;
            this.buttonLogout.Text = "Logout a User";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(488, 152);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(241, 24);
            this.textBoxAppID.TabIndex = 99;
            this.textBoxAppID.Text = "342918918244277";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(485, 202);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(241, 32);
            this.buttonLogin.TabIndex = 81;
            this.buttonLogin.Text = "Login a User";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // userPanel1
            // 
            this.userPanel1.Location = new System.Drawing.Point(0, 0);
            this.userPanel1.Name = "userPanel1";
            this.userPanel1.SignedUserData = null;
            this.userPanel1.Size = new System.Drawing.Size(479, 612);
            this.userPanel1.TabIndex = 80;
            // 
            // userPanel2
            // 
            this.userPanel2.Location = new System.Drawing.Point(759, 6);
            this.userPanel2.Name = "userPanel2";
            this.userPanel2.SignedUserData = null;
            this.userPanel2.Size = new System.Drawing.Size(470, 612);
            this.userPanel2.TabIndex = 79;
            // 
            // labelFullNameVal
            // 
            this.labelFullNameVal.AutoSize = true;
            this.labelFullNameVal.Location = new System.Drawing.Point(294, 131);
            this.labelFullNameVal.Name = "labelFullNameVal";
            this.labelFullNameVal.Size = new System.Drawing.Size(0, 18);
            this.labelFullNameVal.TabIndex = 64;
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
            // labelAvgAge
            // 
            this.labelAvgAge.AutoSize = true;
            this.labelAvgAge.Location = new System.Drawing.Point(492, 425);
            this.labelAvgAge.Name = "labelAvgAge";
            this.labelAvgAge.Size = new System.Drawing.Size(94, 18);
            this.labelAvgAge.TabIndex = 104;
            this.labelAvgAge.Text = "Average Age:";
            // 
            // labelAvgAgeVal
            // 
            this.labelAvgAgeVal.AutoSize = true;
            this.labelAvgAgeVal.Location = new System.Drawing.Point(593, 429);
            this.labelAvgAgeVal.Name = "labelAvgAgeVal";
            this.labelAvgAgeVal.Size = new System.Drawing.Size(0, 18);
            this.labelAvgAgeVal.TabIndex = 105;
            // 
            // labelMutualIntersts
            // 
            this.labelMutualIntersts.AutoSize = true;
            this.labelMutualIntersts.Location = new System.Drawing.Point(492, 466);
            this.labelMutualIntersts.Name = "labelMutualIntersts";
            this.labelMutualIntersts.Size = new System.Drawing.Size(108, 18);
            this.labelMutualIntersts.TabIndex = 106;
            this.labelMutualIntersts.Text = "Mutal Interests:";
            // 
            // labelLocationMidPoint
            // 
            this.labelLocationMidPoint.AutoSize = true;
            this.labelLocationMidPoint.Location = new System.Drawing.Point(492, 447);
            this.labelLocationMidPoint.Name = "labelLocationMidPoint";
            this.labelLocationMidPoint.Size = new System.Drawing.Size(115, 18);
            this.labelLocationMidPoint.TabIndex = 107;
            this.labelLocationMidPoint.Text = "Where To Meet:";
            // 
            // listBoxMutualGroups
            // 
            this.listBoxMutualGroups.FormattingEnabled = true;
            this.listBoxMutualGroups.ItemHeight = 18;
            this.listBoxMutualGroups.Location = new System.Drawing.Point(606, 472);
            this.listBoxMutualGroups.Name = "listBoxMutualGroups";
            this.listBoxMutualGroups.Size = new System.Drawing.Size(120, 94);
            this.listBoxMutualGroups.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 109;
            this.label2.Text = "label2";
            // 
            // labelLocationMidPointVal
            // 
            this.labelLocationMidPointVal.AutoSize = true;
            this.labelLocationMidPointVal.Location = new System.Drawing.Point(603, 447);
            this.labelLocationMidPointVal.Name = "labelLocationMidPointVal";
            this.labelLocationMidPointVal.Size = new System.Drawing.Size(0, 18);
            this.labelLocationMidPointVal.TabIndex = 110;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelFullNameVal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private UserPanel userPanel2;
        private UserPanel userPanel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonFindHalfway;
        private System.Windows.Forms.Label labelAvgAge;
        private System.Windows.Forms.Label labelLocationMidPoint;
        private System.Windows.Forms.Label labelMutualIntersts;
        private System.Windows.Forms.Label labelAvgAgeVal;
        private System.Windows.Forms.Label labelLocationMidPointVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMutualGroups;
    }
}