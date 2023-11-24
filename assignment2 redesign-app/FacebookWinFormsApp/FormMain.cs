﻿using System;
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
using BasicFacebookFeatures.BuilderPattern;

namespace BasicFacebookFeatures
{
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
            UserAverageableDetails userAverageableDetails1 = 
                createUserAverageableDetailsFromUserPanel(userPanel1);
            UserAverageableDetails userAverageableDetails2 =
                createUserAverageableDetailsFromUserPanel(userPanel2);

            UserAverageableDetails averagedDetails = Averageizer.Average(userAverageableDetails1, userAverageableDetails2);

            //Apply tp UI
            labelAvgAgeVal.Text = averagedDetails.Age.ToString();
            labelLocationMidPointVal.Text = averagedDetails.City.Name;
            Utilities.AddAllItemsToListBox(averagedDetails.Groups, listBoxMutualGroups);
        }

        private UserAverageableDetails createUserAverageableDetailsFromUserPanel(UserPanel i_UserPanel)
        {
            //This method does not exist in the 'UserAverageableDetails' class in order to 
            //refrain from limiting 'UserAverageableDetails' to a specific UI 
            UserAverageableDetails userAverageableDetails = new UserAverageableDetails();
            userAverageableDetails.Age = float.Parse(string.IsNullOrEmpty(i_UserPanel.UserAge) ? "0" : i_UserPanel.UserAge);
            userAverageableDetails.Groups = i_UserPanel.UserGroups;
            City placeholderCity;
            City.TryFindCityByName(i_UserPanel.Residence, out placeholderCity);
            userAverageableDetails.City = placeholderCity;

            return userAverageableDetails;
        }
    }
}