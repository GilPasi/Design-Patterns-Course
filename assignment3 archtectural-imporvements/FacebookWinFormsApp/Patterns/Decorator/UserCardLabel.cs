using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Patterns.Decorator
{
    //Essentially the core decorator
    public class UserCardLabel : UserCardDecorator
    {
        private Label m_Label;

        public UserCardLabel(UserCardMixin i_InnerDecorator):base(i_InnerDecorator)
        {
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
                return InnerDecorator.DataUser;
            }
        }

        public override void AssignData()
        {
            UiComponent.Text = DataUser.Name;
        }
    }
}
