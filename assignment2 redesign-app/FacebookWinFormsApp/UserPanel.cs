using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.ObjectModel;
using System.Threading;

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

        internal LoginResult SignedUserData { get; set; }

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

        internal void SignLoginResult(LoginResult i_UserData)
        {
            SignedUserData = i_UserData;
            LoadUser();
        }

        private void LoadUser()
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

            //new Thread(fetchBasicInfo).Start();
            //new Thread(fetchGroups).Start();
            //new Thread(fetchPages).Start();
            //new Thread(fetchAlbums).Start();
            //fetchBasicInfo();
            //fetchGroups();
            //fetchPages();
            fetchAlbums();

            m_LoadedtUserId = SignedUserData.LoggedInUser.Id;
        }

        private bool isFirstLoad()
        {
            return string.IsNullOrEmpty(m_LoadedtUserId);
        }

        private void fetchBasicInfo()
        {
            if (!tableLayoutPanelBasicData.InvokeRequired)
            {
                applyBasicInfo();
            }
            else
            {
                listBoxAlbums.Invoke(new Action(applyBasicInfo));
            }
        }

        private void applyBasicInfo()
        {
            User user = SignedUserData.LoggedInUser;
            userBindingSource.DataSource = new List<User> { user };
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
            fetchItems<Group>(SignedUserData.LoggedInUser.Groups, listBoxGroups, groupBindingSource);
            referNoItemsToRetrieve(listBoxGroups, "groups");
        }

        private void fetchPages()
        {
            fetchItems<Page>(SignedUserData.LoggedInUser.LikedPages, listBoxPages, pageBindingSource);
            referNoItemsToRetrieve(listBoxPages, "pages");
        }

        private void fetchAlbums()
        {
            fetchItems<Album>(SignedUserData.LoggedInUser.Albums, listBoxAlbums, albumBindingSource);
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

        private void fetchItems<T>(Collection<T> i_allItems, Control i_BindedControl, BindingSource i_BinfingSource)
        {
            if (!i_BindedControl.InvokeRequired)
            {
                i_BinfingSource.DataSource = i_allItems;
            }
            else
            {
                listBoxAlbums.Invoke(new Action(() => i_BinfingSource.DataSource = i_allItems));
            }
        }

        //___Handlers__
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resetComponent();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_CurrentPhotoIndex = 0;
            updatePhotoIndex(listBoxAlbums.SelectedItem as Album);
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
            labelPicturePosition.Text = string.Format("{0}/{1}", m_CurrentPhotoIndex + 1, i_SelectedAlbum.Count);
        }

        private void resetComponent()
        {
            Controls.Clear();
            InitializeComponent();
        }
    }
}