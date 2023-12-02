using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
namespace BasicFacebookFeatures.BuilderPattern
{
    internal class BasicUadBuilder : IUadBuilder
    {
        public UserAverageableDetails Build(params object[] i_AverageableArguments)
        {
            validateArguments(i_AverageableArguments);

            UserAverageableDetails returnedInstace = new UserAverageableDetails();
            returnedInstace.Age = (float)i_AverageableArguments[0];
            returnedInstace.Groups = (List<Group>)i_AverageableArguments[1];
            returnedInstace.City = (City)i_AverageableArguments[2];

            return returnedInstace;
        }

        private static void validateArguments(object[] i_AverageableArguments)
        {
            if (i_AverageableArguments.Length < 3)
            {
                throw new ArgumentException("Cannot receive less than 3 arguments (Age, common groups,closest city)");
            }

            if (i_AverageableArguments[0].GetType() != typeof(float))
            {
                throw new ArgumentException("The first argument must be a float");
            }

            if (i_AverageableArguments[1].GetType() != typeof(List<Group>))
            {
                throw new ArgumentException("The second argument must be a list of groups");
            }

            if (i_AverageableArguments[2] != null && i_AverageableArguments[2].GetType() != typeof(City))
            {
                throw new ArgumentException("The third argument must be a city");
            }
        }
    }
}
