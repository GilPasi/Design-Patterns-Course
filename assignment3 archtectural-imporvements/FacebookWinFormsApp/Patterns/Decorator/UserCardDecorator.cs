using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Patterns.Decorator
{
    public abstract class UserCardDecorator : UserCardMixin
    {
        protected UserCardMixin m_InnerDecorator;
        protected Control m_UiComponent;
        public abstract Control UiComponent { get; set; }

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

        public override void Load()
        {
            AssertDataAndUiExist();
            AssignData();
            InnerDecorator.Load();
        }
        public abstract void AssignData();
    }
}
