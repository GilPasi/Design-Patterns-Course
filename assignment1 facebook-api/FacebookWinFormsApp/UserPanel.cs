using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using System.Linq;

namespace BasicFacebookFeatures
{
    public partial class UserPanel : System.Windows.Forms.UserControl
    {
        private int m_CurrentPhotoIndex = 0;
        private string m_LoadedtUserId;

        public UserPanel()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }
        //___Properties___

        public LoginResult SignedUserData { get; set; }

        public string UserAge
        {
            get 
            {
                return labelAgeVal.Text;
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
                return labelResidenceVal.Text;
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
            fetchBasicInfo();
            fetchGroups();
            fetchPages();
            fetchAlbums();
            m_LoadedtUserId = SignedUserData.LoggedInUser.Id;

        }

        private bool isFirstLoad()
        {
            return string.IsNullOrEmpty(m_LoadedtUserId);
        }

        private void fetchBasicInfo()
        {
            User user = SignedUserData.LoggedInUser;
            labelFullNameVal.Text = user.Name;
            labelGenderVal.Text = user.Gender.ToString();
            string birthday = user.Birthday;
            formatBirthDay(ref birthday);

            labelBirthdayVal.Text = DateTime.Parse(birthday).GetDateTimeFormats()[2];
            float userAge = calcAge(birthday);
            labelAgeVal.Text = userAge.ToString("F1");
            labelResidenceVal.Text = user?.Location?.Name;
            string imageUrl = user.PictureLargeURL;
            pictureBoxProfile.LoadAsync(imageUrl);
        }

        private void fetchGroups()
        {
            foreach (Group group in SignedUserData.LoggedInUser.Groups)
            {
                listBoxGroups.Items.Add(group);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void fetchPages()
        {
            foreach (Page likedPage in SignedUserData.LoggedInUser.LikedPages)
            {
                listBoxPages.Items.Add(new FormattedPage(likedPage));
            }

            if (listBoxPages.Items.Count == 0)
            {
                MessageBox.Show("No pages to retrieve :(");
            }
        }

        private void fetchAlbums()
        {
            foreach (Album album in SignedUserData.LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(new FormattedAlbum(album));
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No albums to retrieve :(");
            }
        }

        //___Handlers___

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group currentGroup = listBoxGroups.SelectedItem as Group;
            richTextBoxCurrentGroupDescription.Text = currentGroup.Description;

            if (currentGroup.ImageLarge != null)
            {
                pictureBoxCurrentGroup.Image = currentGroup.ImageLarge;
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormattedPage currentPage = listBoxPages.SelectedItem as FormattedPage;
            richTextBoxCurrentPageDescription.Text = currentPage.Description;

            if (currentPage.ImageLarge != null)
            {
                pictureBoxCurrentPage.Image = currentPage.ImageLarge;
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                m_CurrentPhotoIndex = 0;
                FormattedAlbum selectedAlbum = listBoxAlbums.SelectedItem as FormattedAlbum;
                updatePhotoIndex(selectedAlbum);
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxCurrentAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
            }
        }

        private void buttonNextPicture_Click(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                FormattedAlbum selectedAlbum = listBoxAlbums.SelectedItem as FormattedAlbum;
                if (m_CurrentPhotoIndex + 1 < selectedAlbum.Count)
                {
                    Photo nextPhoto = selectedAlbum.Photos[++m_CurrentPhotoIndex];
                    pictureBoxCurrentAlbum.Image = nextPhoto.ImageNormal;
                    updatePhotoIndex(selectedAlbum);
                }

            }
        }

        private void buttonPrevPicture_Click(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                FormattedAlbum selectedAlbum = listBoxAlbums.SelectedItem as FormattedAlbum;
                if (m_CurrentPhotoIndex - 1 >= 0)
                {
                    Photo prevPhoto = selectedAlbum.Photos[--m_CurrentPhotoIndex];
                    pictureBoxCurrentAlbum.Image = prevPhoto.ImageNormal;
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

        private void updatePhotoIndex(FormattedAlbum i_SelectedAlbum)
        {
            labelPicturePosition.Text = string.Format("{0}/{1}", m_CurrentPhotoIndex + 1, i_SelectedAlbum.Count);
        }

        private void resetComponent()
        {
            Controls.Clear();
            InitializeComponent();
        }
    }
}