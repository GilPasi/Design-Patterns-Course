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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.radioButtonUser2 = new System.Windows.Forms.RadioButton();
            this.radioButtonUser1 = new System.Windows.Forms.RadioButton();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.userPanel1 = new BasicFacebookFeatures.UserPanel();
            this.userPanel2 = new BasicFacebookFeatures.UserPanel();
            this.labelFullNameVal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.radioButtonUser2);
            this.tabPage1.Controls.Add(this.radioButtonUser1);
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
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(488, 201);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(241, 32);
            this.buttonLogout.TabIndex = 102;
            this.buttonLogout.Text = "Logout a User";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // radioButtonUser2
            // 
            this.radioButtonUser2.AutoSize = true;
            this.radioButtonUser2.Location = new System.Drawing.Point(633, 232);
            this.radioButtonUser2.Name = "radioButtonUser2";
            this.radioButtonUser2.Size = new System.Drawing.Size(96, 22);
            this.radioButtonUser2.TabIndex = 101;
            this.radioButtonUser2.Text = "Right User";
            this.radioButtonUser2.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser1
            // 
            this.radioButtonUser1.AutoSize = true;
            this.radioButtonUser1.Checked = true;
            this.radioButtonUser1.Location = new System.Drawing.Point(488, 232);
            this.radioButtonUser1.Name = "radioButtonUser1";
            this.radioButtonUser1.Size = new System.Drawing.Size(86, 22);
            this.radioButtonUser1.TabIndex = 100;
            this.radioButtonUser1.TabStop = true;
            this.radioButtonUser1.Text = "Left User";
            this.radioButtonUser1.UseVisualStyleBackColor = true;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(488, 260);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(241, 24);
            this.textBoxAppID.TabIndex = 99;
            this.textBoxAppID.Text = "342918918244277";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(488, 163);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(241, 32);
            this.buttonLogin.TabIndex = 81;
            this.buttonLogin.Text = "Load User";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // userPanel1
            // 
            this.userPanel1.Location = new System.Drawing.Point(0, 0);
            this.userPanel1.Name = "userPanel1";
            this.userPanel1.Size = new System.Drawing.Size(479, 612);
            this.userPanel1.TabIndex = 80;
            this.userPanel1.UserData = null;
            // 
            // userPanel2
            // 
            this.userPanel2.Location = new System.Drawing.Point(759, 6);
            this.userPanel2.Name = "userPanel2";
            this.userPanel2.Size = new System.Drawing.Size(470, 612);
            this.userPanel2.TabIndex = 79;
            this.userPanel2.UserData = null;
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
        private System.Windows.Forms.RadioButton radioButtonUser2;
        private System.Windows.Forms.RadioButton radioButtonUser1;
        private System.Windows.Forms.Button buttonLogout;
    }
}