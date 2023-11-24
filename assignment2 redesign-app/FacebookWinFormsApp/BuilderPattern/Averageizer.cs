using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.SingletonPattern;
using FacebookWrapper.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BasicFacebookFeatures.BuilderPattern
{
    //This is the Composer component
    public static class Averageizer
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
                io_UsersMean.City = findMidPoint(i_City1, i_City2);   
            }
            catch
            {
                io_UsersMean.City = City.MissingDataCity;
            }
        }

        private static City findMidPoint(params City[] i_Cities)
        {
            Coordinate[] avgCoordinates;
            if (!isCitiesArrayValid(i_Cities))
            {
                return City.MissingDataCity; //In order to average, at least one valid city is required
            }
            else
            {
                avgCoordinates = findCitiesMean(i_Cities);
            }

            City averageLocation = new City();
            averageLocation.CoordinateX = avgCoordinates[0];
            averageLocation.CoordinateY = avgCoordinates[1];
            decimal minDistance = decimal.MaxValue;
            City closestCity = null;

            foreach (City city in CitiesDataBase.Instance.AllCities)
            {
                decimal cityAverageLocationDistance = averageLocation.Distance(city);
                if (minDistance > cityAverageLocationDistance)
                {
                    minDistance = cityAverageLocationDistance;
                    closestCity = city;
                }
            }
            return closestCity;
        }

        private static bool isCitiesArrayValid(City[] i_Cities)
        {
            foreach (City city in i_Cities)
            {
                if (!city.IsMissingDataCity)
                {
                    return true;
                }
            }

            return false;
        }

        private static Coordinate[] findCitiesMean(params City[] i_Cities)
        {
            List<Coordinate> xCoordinates = new List<Coordinate>(i_Cities.Length);
            List<Coordinate> yCoordinates = new List<Coordinate>(i_Cities.Length);

            foreach (City city in i_Cities)
            {
                if (city.CoordinateX != null)
                {
                    xCoordinates.Add(city.CoordinateX);
                }

                if (city.CoordinateY != null)
                {
                    yCoordinates.Add(city.CoordinateY);
                }
            }
            Coordinate avgX = new Coordinate();
            Coordinate avgY = new Coordinate();

            avgX.Value = Coordinate.Average(xCoordinates.ToArray());
            avgY.Value = Coordinate.Average(yCoordinates.ToArray());

            return new Coordinate[] { avgX, avgY };
        }
    }
}
