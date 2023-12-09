using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Patterns.Decorator
{
    //Essentially the core decorator
    public class CoreUserCard : UserCardMixin
    {
        private Label m_Label;
        private User m_User;

        public CoreUserCard(User i_DataUser)
        {
            if (i_DataUser != null)
            {
                m_User = i_DataUser;
            }
        }

        public override Control UiComponent
        {
            get
            {
                return m_Label;
            }
            set
            {
                if (value is Label)
                {
                    Utilities.AssignToReadOnlyClass(ref m_Label, value as Label);
                }
                else
                {
                    throw new ArgumentException("This class'es UiComponent is a Label," +
                        $" cannot accept {value.GetType()} instead");
                }
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

        public override void PropagateLoadIfNeeded()
        {
            UiComponent.Text = i_IgnoreVacancy ?
                            DataUser.Name :
                            UiComponent.Text + DataUser.Name;
        }
    }
}
