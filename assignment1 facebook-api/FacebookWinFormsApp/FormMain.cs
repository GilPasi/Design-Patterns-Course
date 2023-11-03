using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
namespace BasicFacebookFeatures
{

    //Side Quests (Delete afterwards ):
    //Delete copying to clipboard
    // REmove redundant namespaces
    // Better logo
    public partial class FormMain : Form
    {
        private int m_CurrentPhotoIndex = 0;
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(getDefaultUserIdentifiers());

            LoginResult loginResult = FacebookService.Login(
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos"
            );

            if (isValidLoginResult(loginResult))
            {
                if (radioButtonUser1.Checked)
                {
                    userPanel1.LoadLoginResult(loginResult);
                }
                else
                {
                    userPanel2.LoadLoginResult(loginResult);
                }
                buttonLogout.Enabled = true;
            }
        }

        private static bool isValidLoginResult(LoginResult loginResult)
        {
            return string.IsNullOrEmpty(loginResult.ErrorMessage) && loginResult.LoggedInUser != null;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
        }

        private static string getProjectRoot()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string binFolderPath = Path.Combine(currentDirectory, "bin");// Signify the project root

            while (!Directory.Exists(binFolderPath))
            {
                currentDirectory = Directory.GetParent(currentDirectory)?.FullName;
                binFolderPath = Path.Combine(currentDirectory, "bin");
            }

            return currentDirectory;
        }


        private string getDefaultUserIdentifiers()
        {
            const string k_FileName = "decoupled_identifiers.txt";
            string filePath = Path.Combine(getProjectRoot(), k_FileName);

            if (File.Exists(filePath))
            {
                return File.ReadLines(filePath).FirstOrDefault();
            }
            else
            {
                return string.Empty;

            }
        }
    }
}