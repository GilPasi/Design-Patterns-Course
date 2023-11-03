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

        public UserPanel()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        public LoginResult UserData { get; set; }


        //FacebookWrapper.LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //TODO: Remove this before pushing
            Clipboard.SetText(getDefaultUserIdentifiers());

            //login();
            
        }

        public void LoadLoginResult(LoginResult i_UserData)
        {
            if (UserData == null)
            {
                UserData = i_UserData;
                fetchBasicInfo();
                fetchGroups();
                fetchPages();
                fetchAlbums();
            }
        }

        private void fetchBasicInfo()
        {
            User user = UserData.LoggedInUser;
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
            io_String = new string (charArray);
        }

        private void fetchGroups()
        {
            foreach (Group group in UserData.LoggedInUser.Groups)
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
            foreach (Page likedPage in UserData.LoggedInUser.LikedPages)
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
            foreach (Album album in UserData.LoggedInUser.Albums)
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

        private void updatePhotoIndex(FormattedAlbum i_SelectedAlbum)
        {
            labelPicturePosition.Text = string.Format("{0}/{1}", m_CurrentPhotoIndex + 1, i_SelectedAlbum.Count);
        }

        //___Utilities methods___

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            UserData = null;
            Controls.Clear();
            InitializeComponent();
        }
    }
}

