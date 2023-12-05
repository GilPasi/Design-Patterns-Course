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

        public override User DataUser
        {
            get
            {
                return m_User;
                //Imututable anyway
            }
            set
            {
                Utilities.AssignToReadOnlyClass(ref m_User, value);
            }
        }

        public override void HardLoad()
        {
            AssertDataAndUiExist();
            UiComponent.Text = DataUser.Name;
        }

        public override void SoftLoad()
        {
            AssertDataAndUiExist();
            UiComponent.Text += DataUser.Name;
        }
    }
}
