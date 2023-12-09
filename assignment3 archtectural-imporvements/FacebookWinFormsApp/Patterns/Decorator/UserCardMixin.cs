using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
namespace BasicFacebookFeatures.Patterns.Decorator
{
    public abstract class UserCardMixin
    {
        public abstract void Load();
        public abstract User DataUser { get;}

    }
}
