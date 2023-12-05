using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.BuilderPattern
{
    //uad = userAverageableDetail
    public interface IUadBuilder
    {
        UserAverageableDetails Build(params object[] i_AverageableArguments);
    }
}
