using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BasicFacebookFeatures
{
    public class City
    {

        //___Properties___
        private static List<City> s_AllCities;
        private Coordinate m_CoordinateX = new Coordinate();
        private Coordinate m_CoordinateY = new Coordinate();
        public string Name { get; set; }
        public string Country { get; set; }

        public bool UserFriendlyToString { get; set; } = true;

        public static City FindCityByName(string i_CityName)
        {
            foreach (City city in s_AllCities)
            {
                if (i_CityName.Equals(city.Name))
                {
                    return city;
                }
            }
            throw new KeyNotFoundException($"The city {i_CityName} does not exist in the DB or was not able to parse properly." +
                $" Make sure to follow the format {ParseFormat}");
        }

        public override string ToString()
        {
            if (UserFriendlyToString)
            {
                return Name;
            }
            else
            {
                return $"City:{Name},Country:{Country}, ({m_CoordinateX}|{m_CoordinateY})";
            }
        }

        public static string ParseFormat
        {
            get 
            {
                return @"<Y Coordinate><Tab><X Coordinate><Tab><City Name>";
            }
        }

        //___Constructors___
        static City()
        {
            string directoryWithAssetsFolder = Utilities.ClimbDirectoryLevels("assets");
            const string k_FileName = "israel_cities.txt";
            const string k_Subdir = "assets";
            string filePath = Path.Combine(directoryWithAssetsFolder, k_Subdir, k_FileName);

            if (File.Exists(filePath))
            {
                string[]  lines = File.ReadAllLines(filePath);
                s_AllCities = new List<City>(lines.Length);

                for(int i = 1; i < lines.Length; i++)// Skip the headers
                {
                    try
                    {
                        s_AllCities.Add(ParseTXT(lines[i]));
                    }
                    catch
                    {
                        //Ignore invalid parse, this issue is addressed when in the FindCity() method
                    }
                }
            }

        }
        public City() 
        {
            m_CoordinateX.Axis = 'X';
            m_CoordinateY.Axis = 'Y';
        }

        public static City ParseTXT(string i_Text)
        {
            City parsedCity = new City();
            string[] splittedText = getCityUnparsedDetails(i_Text);

            const int k_MinimumCommaCount = 2;

            if (splittedText.Length < k_MinimumCommaCount + 1)
            {
                throw new FormatException($"A city format must contain at least {k_MinimumCommaCount} commas");
            }
            parsedCity.Name = splittedText[0];
            char axis1 = parsedCity.m_CoordinateX.Axis;
            char axis2 = parsedCity.m_CoordinateY.Axis;
            parsedCity.m_CoordinateX.Value = parseCoordinateValue(axis1, splittedText[1]);
            parsedCity.m_CoordinateY.Value = parseCoordinateValue(axis2, splittedText[2]);

            return parsedCity;
        }

        public static City CreateCityFromDataBase(string i_CityName)
        {
            /*This implementation is not hermetic, it is possible to have two cities 
            //ith the same name but for the current use it will suffice.In addition there
            //are powerful databases that can perform easily such operations. Therefore it is 
            //not worth investing time in this specific requsite.*/
            string directoryWithAssetsFolder = Utilities.ClimbDirectoryLevels("assets");
            const string k_FileName = "israel_cities.txt";
            const string k_Subdir = "assets";
            string filePath = Path.Combine(directoryWithAssetsFolder, k_Subdir, k_FileName);


            if (File.Exists(filePath))
            {
                var lines = File.ReadLines(filePath).Skip(1);//Skip the headers

                foreach (string line in lines)
                {
                    string[] unparsedDetails = getCityUnparsedDetails(i_CityName);
                    if (i_CityName.Equals(unparsedDetails[0]))
                    {
                        return ParseTXT(line);
                    }
                }
                throw new KeyNotFoundException($"The city name {i_CityName} does not exist in the database");
            }
            else
            {
                throw new FileNotFoundException($"Database file does not exists, please make sure there" +
                    $" is a file named {k_FileName} in the path {filePath}");
            }
        }

        private static string[] getCityUnparsedDetails(string i_Text)
        {
            return i_Text.Split('\t');
        }

        //___Operations___
        public decimal Distance(City i_Other)
        {
            double deltaX = (double)m_CoordinateX.Distance(i_Other.m_CoordinateX);
            double deltaY = (double)m_CoordinateY.Distance(i_Other.m_CoordinateY);
            double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return (decimal)result;
        }
        public static City FindMidPoint(params City[] i_Cities)
        {
            Coordinate[] avgCoordinates = findCitiesMean(i_Cities);
            City averageLocation = new City();
            averageLocation.m_CoordinateX = avgCoordinates[0];
            averageLocation.m_CoordinateY = avgCoordinates[1];
            decimal minDistance = decimal.MaxValue;
            City closestCity = null;

            foreach (City city in s_AllCities)
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


        private static Coordinate[] findCitiesMean(params City[] i_Cities)
        {
            List<Coordinate> xCoordinates = new List<Coordinate>(i_Cities.Length);
            List<Coordinate> yCoordinates = new List<Coordinate>(i_Cities.Length);

            foreach (City city in i_Cities)
            {
                xCoordinates.Add(city.m_CoordinateX);
                yCoordinates.Add(city.m_CoordinateY);
            }
            Coordinate avgX = new Coordinate();
            Coordinate avgY = new Coordinate();

            avgX.Value = Coordinate.Average(xCoordinates.ToArray());
            avgY.Value = Coordinate.Average(yCoordinates.ToArray());

            return new Coordinate[] {avgX, avgY };
        }

        //___Minor Methods___

        private static decimal parseCoordinateValue(char i_CoordinateAxis, string i_Text)
        {
            decimal coordinate;
            if (decimal.TryParse(i_Text, out coordinate))
            {
                return coordinate;
            }
            else
            {
                throw new FormatException(string
                    .Format("Error: coordinate {0} is none decimal parseable", i_CoordinateAxis));
            }
        }

        public string ExtractCityNameFromTXT(string i_Text)
        {
            return i_Text.Split(new char[] { '\t' })[0];
        }
    }
}
