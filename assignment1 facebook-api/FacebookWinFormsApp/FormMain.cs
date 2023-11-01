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
    public partial class FormMain : Form
    {
        const int k_DefaultFieldSize = 10;
        private List<Label> m_UserFields = new List<Label>(k_DefaultFieldSize);
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_UserFields.Add(labelFullNameVal);
            m_UserFields.Add(labelGenderVal);
            m_UserFields.Add(labelAgeVal);
            m_UserFields.Add(labelBirthdayVal);
            m_UserFields.Add(labelResidenceVal);

        }

        FacebookWrapper.LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //TODO: Remove this before pushing
            Clipboard.SetText(getDefaultUserIdentifiers());

            if (m_LoginResult == null)
            {
                login();
            }
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

        private void login()
        {
            m_LoginResult = FacebookService.Login(
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

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                User user = m_LoginResult.LoggedInUser; 
                buttonLogin.Text = $"Logged in as {user.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                labelFullNameVal.Text = user.Name;
                labelGenderVal.Text = user.Gender.ToString();
                labelBirthdayVal.Text = user.Birthday;
                labelAgeVal.Text = calcAge(user.Birthday).ToString();
                labelResidenceVal.Text = user.Location.Name;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                fetchGroups();

            }
        }

        private void fetchGroups() 
        {
            foreach (Group group in m_LoginResult.LoggedInUser.Groups)
            {
                listBoxGroups.Items.Add(group);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        //___Handlers___

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            foreach(Label field in m_UserFields)
            {
                field.Text = string.Empty;
            }
        }


        private void textBoxAppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group currentGroup = listBoxGroups.SelectedItem as Group;
            pictureBoxCurrentGroup.Image = currentGroup.ImageLarge;
            richTextBoxCurrentGroupDescribtion.Text = currentGroup.Description;
        }


        //___Utilities methods___

        private float calcAge(string i_BirthDate)
        {
            DateTime birthDate = DateTime.Parse(i_BirthDate);
            DateTime currentDate = DateTime.Now;
            const int k_MonthsCount = 12;
            float res = currentDate.Year - birthDate.Year;
            res += (currentDate.Month - birthDate.Month) / k_MonthsCount;
            return res;
        }

    }
}
