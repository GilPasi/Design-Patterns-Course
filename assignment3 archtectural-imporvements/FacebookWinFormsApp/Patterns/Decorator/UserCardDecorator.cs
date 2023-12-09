using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Patterns.Decorator
{
    public abstract class UserCardDecorator : UserCardMixin
    {
        protected UserCardMixin m_InnerDecorator;
        protected Control m_UiComponent;


        public UserCardDecorator(UserCardMixin i_InnerDecorator)
        {
            m_InnerDecorator = i_InnerDecorator;
        }


        public override User DataUser
        {
            get
            {
                return InnerDecorator.DataUser;
            }
        }

        public UserCardMixin InnerDecorator
        {
            get
            {
                return m_InnerDecorator;
            }
        }

        public void AssertInnerDecorator(UserCardMixin i_PreviousDecorator)
        {
            if (i_PreviousDecorator == null)
            {
                throw new ArgumentException(
                    "Cannot decorate a null object.In order to create a neutral " +
                    "object use a CoreDecorator instance like so: " +
                    $"'new {this.GetType().Name}(new CoreUserCard(<UserIntance>);')");
            }
        }
    }
}
