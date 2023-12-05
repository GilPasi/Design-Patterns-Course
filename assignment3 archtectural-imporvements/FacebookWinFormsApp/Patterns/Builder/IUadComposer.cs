using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.BuilderPattern
{
    //uad = userAverageableDetails
    public interface IUadComposer
    {
        UserAverageableDetails Average(params UserAverageableDetails[] i_UadsToAverage);

        IUadBuilder Builder { get;}
    }
}
