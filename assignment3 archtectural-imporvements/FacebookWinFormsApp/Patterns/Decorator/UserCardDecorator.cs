namespace BasicFacebookFeatures.Patterns.Decorator
{
    public abstract class UserCardDecorator : UserCardMixin
    {
        public UserCardMixin PreviousDecorator
        {
            get;set;
        }   
    }
}
