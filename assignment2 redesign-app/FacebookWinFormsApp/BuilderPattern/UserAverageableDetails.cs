using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures.BuilderPattern
{
    //This is the Builder component
    internal partial class UserAverageableDetails
    {
        /*This class aggregate all the details of a user that can be "averaged" in 
         some way.
        For example the average age of two users or the middle point between 
        their locations.
        It is partial so it will be possible to expand the definition in the future.*/
        public float Age{ get; set; }
        public City City { get; set; }
        public List<Group> Groups { get; set; }
    }
}
