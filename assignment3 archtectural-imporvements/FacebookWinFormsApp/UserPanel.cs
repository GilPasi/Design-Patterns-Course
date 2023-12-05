﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.ObjectModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class UserPanel : UserControl
    {
        private int m_CurrentPhotoIndex = 0;
        private string m_LoadedtUserId;
        private bool m_FormClosing = false;

        public UserPanel()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }
        //___Properties___

        public LoginResult SignedUserData { get; set; }

        public UserCard Card
        {
            get;set;
        }

        public string UserAge
        {
            get
            {
                return string.Empty;
                //TODO: Fix
                //return labelAgeVal.Text;
            }
        }

        public List<Group> UserGroups
        {
            get
            {
                List<Group> userGroups = new List<Group>();
                foreach (object item in listBoxGroups.Items)
                {
                    userGroups.Add(item as Group);
                }
                return userGroups;
            }
        }

        public string Residence
        {
            get 
            {
                return string.Empty;
                //TODO: Fix
                //return labelResidenceVal.Text;
            }
        }

        public void SignLoginResult(LoginResult i_UserData)
        {
            if (i_UserData == null)
            {
                return;
            }

             if (DoesRequireLocking(i_UserData))
            {
                const bool k_DisableAll = false;
                switchEnabled(k_DisableAll);
                buttonLoad.Enabled = true;
                buttonClear.Enabled = true;

            }
              
            buttonLoad.Text = $"Load {i_UserData.LoggedInUser.FirstName}";
            SignedUserData = i_UserData;
        }

        private bool DoesRequireLocking(LoginResult i_UserData)
        {
            //If the loaded user and the signed user are not the same user, 
            //there is a chance of sending invalid requests. Therefore a lock 
            //is required. One exception is the first request when the loaded user is null.
            return m_LoadedtUserId != i_UserData.LoggedInUser.Id && SignedUserData != null;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (SignedUserData == null)
            {
                return;
            }

            if (!isFirstLoad())
            {
                resetComponent();
            }

            const bool k_EnableAll = true;
            switchEnabled(k_EnableAll);

            new Thread(fetchBasicInfo).Start();
            new Thread(fetchGroups).Start();
            new Thread(fetchPages).Start();
            new Thread(fetchAlbums).Start();
            m_LoadedtUserId = SignedUserData.LoggedInUser.Id;
        }

        private bool isFirstLoad()
        {
            return string.IsNullOrEmpty(m_LoadedtUserId);
        }

        private void fetchBasicInfo()
        {
            fetchItems(tableLayoutPanelCard, new Action(applyBasicInfo));
        }

        private void fetchItems(Control i_BindedControl, Action i_FetchAction)
        {
            if (!i_BindedControl.InvokeRequired)
            {
                i_FetchAction.Invoke();
            }
            else
            {
                i_BindedControl.Invoke(i_FetchAction);
            }
        }

        private void applyBasicInfo()
        {
            Card = new UserCard(tableLayoutPanelCard, SignedUserData.LoggedInUser);
            Card.ForceLoad();
            string imageUrl = SignedUserData.LoggedInUser.PictureLargeURL;
            pictureBoxProfile.LoadAsync(imageUrl);
        }

        private void fetchGroups()
        {
            fetchItems(listBoxGroups,
                new Action(() => groupBindingSource.DataSource = SignedUserData.LoggedInUser.Groups));
            referNoItemsToRetrieve(listBoxGroups, "groups");
        }

        private void fetchPages()
        {
            fetchItems(listBoxPages,
                new Action(() => pageBindingSource.DataSource = SignedUserData.LoggedInUser.LikedPages));
            referNoItemsToRetrieve(listBoxPages, "pages");
        }

        private void fetchAlbums()
        {
            fetchItems(listBoxAlbums, 
                new Action(() => albumBindingSource.DataSource = SignedUserData.LoggedInUser.Albums));
            referNoItemsToRetrieve(listBoxAlbums, "albums");
            Album selectedAlbum = null;
            listBoxAlbums.Invoke(new Action(() => selectedAlbum = listBoxAlbums.SelectedItem as Album));
            listBoxAlbums.Invoke(new Action(() => updatePhotoIndex(selectedAlbum)));
        }

        private void referNoItemsToRetrieve(ListBox i_ItemsToRetrieveListBox, string i_ItemsNameToPresent = "items")
        {
            string noRetriveMessage = string.Format("No {0} to retrieve :(", i_ItemsNameToPresent);
            if (i_ItemsToRetrieveListBox.Items.Count == 0)
            {
                MessageBox.Show(noRetriveMessage);
            }

        }

        //___Handlers___

        private void buttonNextPicture_Click(object sender, EventArgs e)
        {
            changeCurrentPicture(m_CurrentPhotoIndex + 1);
        }

        private void buttonPrevPicture_Click(object sender, EventArgs e)
        {
            changeCurrentPicture(m_CurrentPhotoIndex - 1);
        }

        private void changeCurrentPicture(int i_IndexToShow)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (i_IndexToShow >= 0 && i_IndexToShow < selectedAlbum.Count)
                {
                    m_CurrentPhotoIndex = i_IndexToShow;
                    Photo newPhotoToShow = selectedAlbum.Photos[i_IndexToShow];
                    imageThumbPictureBox.LoadAsync(newPhotoToShow.PictureThumbURL);
                    updatePhotoIndex(selectedAlbum);
                }
            }
        }

        public void MainFormLogout_Clicked(object sender, EventArgs e) 
        {
            buttonLoad.Text = "Load User";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resetComponent();
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_FormClosing = true;
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Avoid NullReferenceException when closing the window 
            //otherwise this method is triggered with null album
            if (!m_FormClosing)
            {
                m_CurrentPhotoIndex = 0;
                updatePhotoIndex(listBoxAlbums.SelectedItem as Album);
            }
        }


        //___Minor Methods___

        private float calcAge(string i_BirthDate)
        {           
            DateTime birthDate = DateTime.Parse(i_BirthDate);
            DateTime currentDate = DateTime.Now;
            const float k_MonthsCount = 12;
            float monthsToAdd = (currentDate.Month - birthDate.Month) / k_MonthsCount;
            float res = currentDate.Year - birthDate.Year;
            res += monthsToAdd;
            return res;
        }

        private void switchEnabled(bool i_Enabled)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = i_Enabled;
            }
        }

        private void formatBirthDay(ref string io_UnformattedBirthday)
        {
            //Swapping months and days to fit the DateTime format
            swapChar(ref io_UnformattedBirthday, 0, 3);
            swapChar(ref io_UnformattedBirthday, 1, 4);
        }

        private void swapChar(ref string io_String, int idx1, int idx2)
        {
            char[] charArray = io_String.ToCharArray();
            char charHolder = charArray[idx1];
            charArray[idx1] = charArray[idx2];
            charArray[idx2] = charHolder;
            io_String = new string(charArray);
        }

        private void updatePhotoIndex(Album i_SelectedAlbum)
        {
            if (i_SelectedAlbum != null)
            {
                labelPicturePosition.Text = string.Format("{0}/{1}",
                    m_CurrentPhotoIndex + 1, i_SelectedAlbum.Count);
            }
        }

        private void resetComponent()
        {
            Controls.Clear();
            InitializeComponent();
        }
    }
}