using BasicFacebookFeatures.IteratorPattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.SingletonPattern
{
    //This is the Singleton component

    internal  sealed class CitiesDataBase
    {
        const string k_FileName = "israel_cities.txt";
        const string k_Subdir = "assets";
        private static CitiesDataBase m_Instance = null;

        public static CitiesDataBase Instance
        {
            get 
            {
                if (m_Instance == null)
                {
                    m_Instance = new CitiesDataBase();
                }

                return m_Instance;
            }
        }

        //___Properties___
        public IEnumerable<City> AllCities {
            get
            {
                string directoryWithAssetsFolder = Utilities.ClimbDirectoryLevels("assets");
                string filePath = Path.Combine(directoryWithAssetsFolder, k_Subdir, k_FileName);

                return new CsvIterator<City>() { FilePath = filePath, Parser = City.Parser}.AllItems;
            }
        }

        public string ParseFormat
        {
            get
            {
                return @"<Y Coordinate><Tab><X Coordinate><Tab><City Name>";
            }
        }


        //___Queries___

        public City FindCityByName(string i_CityName)
        {
            City city;
            if (TryFindCityByName(i_CityName, out city))
            {
                return city;
            }
            else
            {
                throw new KeyNotFoundException($"The city {i_CityName} does not exist in the DB or was not able to parse properly." +
                    $" Make sure to follow the format {ParseFormat}");
            }
        }

        public bool TryFindCityByName(string i_CityName, out City o_City)
        {
            foreach (City city in AllCities)
            {
                if (i_CityName.Equals(city.Name))
                {
                    o_City = city;
                    return true;
                }
            }
            o_City = null;
            return false;
        }
    }
}
