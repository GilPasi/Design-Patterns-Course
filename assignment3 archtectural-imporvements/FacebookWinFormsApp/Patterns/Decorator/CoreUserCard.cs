using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Patterns.Decorator
{
    //Essentially the core decorator
    public class CoreUserCard : UserCardMixin
    {
        private User m_User;

        public CoreUserCard(User i_DataUser)
        {
            if (i_DataUser != null)
            {
                m_User = i_DataUser;
            }
        }

        //Readonly, dispose the UserCard object if a reset is needed
        public override User DataUser
        {
            get
            {
                return m_User;
            }
        }

        public override void Load()
        {
            /*This specific core-decorator there is no action required.
            Nonetheless it is possible to create other types of core decorators in the
            future that will require some action at the end of the loading chain.
            For this reason it is better to leave the current implementation as is*/
        }
    }
}
