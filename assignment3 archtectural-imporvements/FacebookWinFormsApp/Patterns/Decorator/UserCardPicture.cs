using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Patterns.Decorator
{
    public class UserCardPicture : UserCardDecorator
    {
        private PictureBox m_Picture;

        public UserCardPicture(UserCardMixin i_InnerDecorator) : base(i_InnerDecorator) 
        {    
        }


        public override Control UiComponent 
        {
            get
            {
                return m_Picture;
            }
            set
            {
                Utilities.AssertType<PictureBox>(value);
                m_Picture = (PictureBox)value;
            }
        }

        public override void AssignData()
        {
            string imageUrl = DataUser.PictureLargeURL;
            m_Picture.LoadAsync(imageUrl);
        }


    }
}
