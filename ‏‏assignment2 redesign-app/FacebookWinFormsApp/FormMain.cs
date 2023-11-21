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
using System.Globalization;
using System.Net;


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

        //___Handlers___

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Utilities.GetDefaultUserIdentifiers());

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

        //___Halfway Feature___

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
            string user1Residence = userPanel1.Residence;
            string user2Residence = userPanel2.Residence;
            string messageToPresent;               
            try
            {
                City city1 = City.FindCityByName(user1Residence);
                City city2 = City.FindCityByName(user2Residence);

                City midPoint = City.FindMidPoint(city1, city2);
                messageToPresent = midPoint.Name;
            }
            catch 
            {
                messageToPresent = "Missing data";
            }
            labelLocationMidPointVal.Text = messageToPresent;
        }

        private void referCommonGroups()
        {
            List<Group> groups1 = userPanel1.UserGroups;
            List<Group> groups2 = userPanel2.UserGroups;

            foreach (Group groupFromUser1 in groups1)
            {
                foreach (Group groupFromUser2 in groups2)
                {
                    if (groupFromUser1.Id == groupFromUser2.Id)
                    {
                        listBoxMutualGroups.Items.Add(groupFromUser1);
                        break;
                    }
                }
            }
        }
    }
}