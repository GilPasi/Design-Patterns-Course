using BasicFacebookFeatures.StrategyPattern;
using System;


namespace BasicFacebookFeatures
{
    public class City
    {
        //___Properties___

        /*Most data members are readonly types because the city's 
        state is not supposed the change during the run. In fact,
        it is determined solely by the record in the data base. 
        Altering the city object's state may create doubled truth source.*/
        private Coordinate m_CoordinateX;
        private Coordinate m_CoordinateY;
        private string m_Name;

        public Coordinate CoordinateX {
            get
            {
                return m_CoordinateX;
            }
            set 
            {
                m_CoordinateX = assertReadOnlyField("CoordinateX", value);
                m_CoordinateX.Axis = 'X';
            } 
        }

        public Coordinate CoordinateY
        {
            get
            {
                return m_CoordinateY;
            }
            set
            {
                m_CoordinateY = assertReadOnlyField("CoordinateY", value);
                m_CoordinateX.Axis = 'Y';

            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = assertReadOnlyField("Name", value);
            }
        }

        public bool UserFriendlyToString { get; set; } = true;

        private T assertReadOnlyField<T>(string i_FieldName, T i_Value)
        {
            if (i_Value.Equals(default(T)))
            {
                throw new Exception(
                    $"{i_FieldName} is a read-only field and was already assigned with{i_Value}");
            }
            return i_Value;
        }

        public override string ToString()
        {
            if (UserFriendlyToString)
            {
                return Name;
            }
            else
            {
                return $"City:{Name}, ({m_CoordinateX}|{m_CoordinateY})";
            }
        }

        public static CityParser Parser
        {
            get;private set;
        } = new CityParser();

        public class CityParser : IParser<City>
        {
            public City Parse(string i_Text)
            {
                City parsedCity = new City();
                string[] splittedText = getCityUnparsedDetails(i_Text);

                const int k_MinimumCommaCount = 2;

                if (splittedText.Length < k_MinimumCommaCount + 1)
                {
                    throw new FormatException($"A city format must contain at least {k_MinimumCommaCount} commas");
                }
                parsedCity.Name = splittedText[0];
                parsedCity.m_CoordinateX = new Coordinate(parseCoordinateValue('X', splittedText[1]));
                parsedCity.m_CoordinateY = new Coordinate(parseCoordinateValue('Y', splittedText[2]));

                return parsedCity;
            }
        }


        //___Constructors___

        public City() 
        {
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
