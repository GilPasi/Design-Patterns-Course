using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Text.RegularExpressions;

namespace BasicFacebookFeatures
{
    internal class FormattedPage
    {
        /*This is the Adapter component


        it support a proper ToString method so it will match the ListBox object properly*/
        Page m_InnerPage;
        public FormattedPage(Page i_Page)
        {
            m_InnerPage = i_Page;
        }

        public string Description
        {
            get
            {
                return m_InnerPage.Description;
            }
        }

        public Image ImageLarge
        {
            get
            {
                return m_InnerPage.ImageLarge;
            }
        }

        public override string ToString()
        {
            string namePrefixedToString = m_InnerPage.ToString();
            return RemovePrefixAndURL(namePrefixedToString);
        }

        private string RemovePrefixAndURL(string i_Input)
        {
            i_Input = Regex.Replace(i_Input, "^Name:\\s*", "");

            i_Input = Regex.Replace(i_Input, ", URL:.*", "");

            return i_Input.Trim(); // Trim any leading or trailing spaces
         }
    }
}
