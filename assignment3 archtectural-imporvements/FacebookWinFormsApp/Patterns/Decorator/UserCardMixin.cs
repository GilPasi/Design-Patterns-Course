using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
namespace BasicFacebookFeatures.Patterns.Decorator
{
    public abstract class UserCardMixin
    {

        /*The difference between a hard and a soft load is within the permission 
        to alter the orginal UI structre in the name of loading data.
        e.g if a set table does not support enough rows to satisfy all the data
        in the IUserCard instance, a hard load will proactively add more rows to support its needs,
        whereas a soft load will simply ignore the remaining data.*/

        public abstract void SoftLoad();
        public abstract void HardLoad();

        public abstract Control UiComponent { get; set; }

        public abstract User DataUser { get; set; }

        protected void AssertDataAndUiExist()
        {
            if (DataUser == null)
            {
                throw new MissingMemberException("Cannot load a card while the {0} is missing," +
                    "If you want to reset the state, simply dispose it and set a new IUserCard object");
            }

            if (UiComponent == null)
            {
                throw new MissingMemberException(
                    "UiComponent is missing, please set it before loading the IUserCard object");
            }
        }
    }
}
