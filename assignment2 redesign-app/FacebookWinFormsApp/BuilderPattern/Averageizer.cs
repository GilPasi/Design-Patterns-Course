using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BasicFacebookFeatures.BuilderPattern
{
    //This is the Composer component
    internal static class Averageizer
    {

        public static UserAverageableDetails Average(UserAverageableDetails i_AverageableDetails1,
            UserAverageableDetails i_AverageableDetails2)
        {
            UserAverageableDetails avg = new UserAverageableDetails();
            SetAverageAge(i_AverageableDetails1.Age, i_AverageableDetails2.Age, ref avg);
            SetCommonGroups(i_AverageableDetails1.Groups, i_AverageableDetails2.Groups, ref avg);
            SetClosestCity(i_AverageableDetails1.City, i_AverageableDetails2.City, ref avg);

            return avg;
        }

        public static void SetAverageAge(float i_Age1, float i_Age2, ref UserAverageableDetails io_UsersMean)
        {
            io_UsersMean.Age = (i_Age1 + i_Age2) / 2;
        }

        public static void SetCommonGroups(List<Group> i_Groups1, 
            List<Group> i_Groups2, ref UserAverageableDetails io_UsersMean)
        {
            if (io_UsersMean.Groups == null)
            {
                io_UsersMean.Groups = new List<Group>();   
            }

            foreach (Group groupFromList1 in i_Groups1)
            {
                foreach (Group groupFromList2 in i_Groups2)
                {
                    if (groupFromList1.Id == groupFromList2.Id)
                    {
                        io_UsersMean.Groups.Add(groupFromList1);
                        break;
                    }
                }
            }
        }

        public static void SetClosestCity(City i_City1, City i_City2, ref UserAverageableDetails io_UsersMean)
        {
            //Validate data
            if (i_City1.IsMissingDataCity && !i_City2.IsMissingDataCity)
            {
                io_UsersMean.City = City.MissingDataCity;
                return;
            }

            try
            {
                io_UsersMean.City = City.FindMidPoint(i_City1, i_City2);   
            }
            catch
            {
                io_UsersMean.City = City.MissingDataCity;
            }
        }
    }
}
