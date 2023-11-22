using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class LoginResultProxy : LoginResult
    {
        public LoginResultProxy(LoginResult i_Other)
        {
            LoggedInUser = new UserProxy(i_Other.LoggedInUser);
        }
        public new User LoggedInUser
        {
            get;set;
        }
    }

    internal class UserProxy : User
    {
        public UserProxy(User i_Other)
        {
            foreach (Album album in i_Other.Albums)
            {
                Albums.Add(new AlbumProxy(album));
            }

            Groups = i_Other.Groups;
            LikedPages = i_Other.LikedPages;
            Id = i_Other.Id;
        }
        public new FacebookObjectCollection<Album> Albums {get; set;} = new FacebookObjectCollection<Album>();
        public new string Id { get; private set; }

    }

    internal class AlbumProxy : Album
    {
        public AlbumProxy(Album i_Other)
        {
            foreach (Photo photo in i_Other.Photos)
            {
                Photos.Add(new PhotoProxy(photo));
            }
        }
        public new FacebookObjectCollection<Photo> Photos {get; set;} = new FacebookObjectCollection<Photo>();
    }

    internal class PhotoProxy : Photo
    {
        public PhotoProxy(Photo i_Other)
        {
            PictureThumbURL = i_Other.PictureThumbURL;
        }
        public new string PictureThumbURL
        {
            get; set;
        }
    }
}
