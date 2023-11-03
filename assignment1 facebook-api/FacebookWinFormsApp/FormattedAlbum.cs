using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Facebook;
using FacebookWrapper.ObjectModel;
using System.Text.RegularExpressions;

namespace BasicFacebookFeatures
{
    internal class FormattedAlbum
    {
        private Album m_Album;

        public FormattedAlbum(Album i_Album)
        {
            m_Album = i_Album;
        }

        public FacebookObjectCollection<Photo> Photos
        {
            get 
            {
                return m_Album.Photos;
            }
        }

        public long? Count
        {
            get 
            {
                return m_Album.Count;
            }
        }

        public string PictureAlbumURL
        {
            get 
            {
                return m_Album.PictureAlbumURL;
            }
        }

        public override string ToString()
        {
            string retString = m_Album.ToString();
            int indexOfSubstring = retString.IndexOf("() (Photos:");

            if (indexOfSubstring >= 0)
            {
                retString = retString.Substring(0, indexOfSubstring).Trim();
            }
            return retString;
            
        }
    }
}
