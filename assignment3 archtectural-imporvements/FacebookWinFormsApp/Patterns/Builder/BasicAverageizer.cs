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
    public class BasicAverageizer : IUadComposer
    {
        IUadBuilder m_Builder;

        public BasicAverageizer()
        { }

        public BasicAverageizer(IUadBuilder i_Builder)
        {
            Builder = i_Builder;
        }

        public virtual IUadBuilder Builder
        {
            get
            {
                return m_Builder;
            }
            set 
            {
                m_Builder = value;
            }
        }

        public virtual UserAverageableDetails Average(params UserAverageableDetails [] i_UadsToaverage)
        {
            if (Builder == null)
            {
                throw new MissingMemberException("Cannot average with no builder data-member, please append an IUadBuilder instance");
            }

            List<UserAverageableDetails> filteredUads = 
                i_UadsToaverage.Where(item => item != null).ToList();

            float age = GetAverageAge(filteredUads.ToArray());
            List<Group> groups = GetCommonGroups(filteredUads.ToArray());
            City city = GetClosestCity(filteredUads.ToArray());

            return Builder.Build(age, groups, city);
        }

        public virtual float GetAverageAge(params UserAverageableDetails[] i_UadsToAverage)
        {
            float averageAge = 0;
            foreach (UserAverageableDetails details in i_UadsToAverage)
            {
                averageAge += details.Age;
            }
            averageAge /= i_UadsToAverage.Length;
            return averageAge;
        }

        public virtual List<Group> GetCommonGroups(params UserAverageableDetails[] i_UadsToAverage)
        {
            if (i_UadsToAverage is null || i_UadsToAverage.Length == 0)
            {
                return new List<Group>(0);
            }

            List<Group> massIntersectedList = i_UadsToAverage.First().Groups;
            foreach (UserAverageableDetails uad in i_UadsToAverage)
            {
                {
                    massIntersectedList =  intersectGroups(massIntersectedList, uad.Groups);
                }
            }

            return massIntersectedList;
        }

        private List<Group> intersectGroups(List<Group> i_Groups1, List<Group> i_Groups2)
        {
            List<Group> intersection = new List<Group>();

            foreach (Group groupFromList1 in i_Groups1)
            {
                foreach (Group groupFromList2 in i_Groups2)
                {
                    if (groupFromList1.Id == groupFromList2.Id)
                    {
                        intersection.Add(groupFromList1);
                        break;
                    }
                }
            }

            return intersection;
        }

        public virtual City GetClosestCity(params UserAverageableDetails[] i_UadsToAverage)
        {
            List<City> cities = new List<City>(i_UadsToAverage.Length);

            foreach (UserAverageableDetails uad in i_UadsToAverage)
            {
                City currentCity = uad.City;
                if (currentCity != null)
                {
                    cities.Add(currentCity);
                }
            }
            //Avoid 0 average when the list is empty
            return cities.Count == 0 ? null : findMidPoint(cities.ToArray());
        }

        private City findMidPoint(params City[] i_Cities)
        {
            Coordinate[] avgCoordinates;
            avgCoordinates = findCitiesMean(i_Cities);

            City averageLocation = new City();
            averageLocation.CoordinateX = avgCoordinates[0];
            averageLocation.CoordinateY = avgCoordinates[1];
            return findClosestCityFromDB(averageLocation);
        }

        private static City findClosestCityFromDB(City i_City)
        {
            decimal minDistance = decimal.MaxValue;
            City closestCity = null;

            foreach (City city in CitiesDataBase.Instance.AllCities)
            {
                decimal cityAverageLocationDistance = i_City.Distance(city);
                if (minDistance > cityAverageLocationDistance)
                {
                    minDistance = cityAverageLocationDistance;
                    closestCity = city;
                }
            }
            return closestCity;
        }

        private Coordinate[] findCitiesMean(params City[] i_Cities)
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
