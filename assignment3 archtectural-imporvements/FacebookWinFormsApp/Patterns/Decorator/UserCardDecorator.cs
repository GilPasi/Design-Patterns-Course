using System;
namespace BasicFacebookFeatures.Patterns.Decorator
{
    public abstract class UserCardDecorator : UserCardMixin
    {
        public abstract UserCardMixin InnerDecorator
        {
            get;
        }

        public void AssertInnerDecorator(UserCardMixin i_PreviousDecorator)
        {
            if (i_PreviousDecorator == null)
            {
                throw new ArgumentException(
                    "Cannot decorate a null object.In order to create a neutral " +
                    "object use a CoreDecorator instance like so: " +
                    $"$'new {this.GetType().Name}(new CoreUserCard(<UserIntance>);')");
            }
        }
    }
}
