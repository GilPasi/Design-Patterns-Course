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
    //Create a rejection mechasim
    //Delete the previous cleaning code
    public partial class FormMain : Form
    {
        private const int k_DefaultFieldSize = 10;
        private int m_CurrentPhotoIndex = 0;
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
                float userAge = calcAge(user.Birthday);
                labelAgeVal.Text = userAge.ToString("F1");
                labelResidenceVal.Text = user.Location.Name;
                 string imageUrl = user.PictureLargeURL;
                pictureBoxProfile.LoadAsync(imageUrl);
                fetchGroups();
                fetchPages();
                fetchAlbums();

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

        private void fetchPages()
        {
            foreach (Page likedPage in m_LoginResult.LoggedInUser.LikedPages)
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
            foreach (Album album in m_LoginResult.LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(new FormattedAlbum(album));
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No albums to retrieve :(");
            }
        }

        //___Handlers___

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;

            //buttonLogin.Text = "Login";
            //buttonLogin.BackColor = buttonLogout.BackColor;
            //buttonLogin.Enabled = true;
            //buttonLogout.Enabled = false;

            foreach (Control control in this.Controls)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }

            InitializeComponent();
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
    }
}
