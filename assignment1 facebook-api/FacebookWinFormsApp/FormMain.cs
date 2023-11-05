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
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            buttonLogout.Click += userPanel1.MainFormLogout_Clicked;
            buttonLogout.Click += userPanel2.MainFormLogout_Clicked;

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
                userPanel1.SignLoginResult(loginResult);
                userPanel2.SignLoginResult(loginResult);
                buttonLogout.Enabled = true;
                buttonLogin.Text = $"Logged as: {loginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.GreenYellow;
            }
        }

        private static bool isValidLoginResult(LoginResult loginResult)
        {
            return string.IsNullOrEmpty(loginResult.ErrorMessage) && loginResult.LoggedInUser != null;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.Text = "Login";
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

        private void buttonFindHalfway_Click(object sender, EventArgs e)
        {
            referAverageAge();
            referLocationMidPoint();
            referCommonGroups();
        }

        private void referAverageAge()
        {
            if (!string.IsNullOrEmpty(userPanel1.UserAge) && !string.IsNullOrEmpty(userPanel2.UserAge))
            {
                float age1 = float.Parse(userPanel1.UserAge);
                float age2 = float.Parse(userPanel2.UserAge);
                float? averageAge = (age1 + age2) / 2;
                labelAvgAgeVal.Text = averageAge.ToString();
            }
        }

        private void referLocationMidPoint()
        { 
        }

        private void referCommonGroups()
        { 
        }
    }
}