using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Coordinate
    {

        //___Properties and Data-Members___
        private char m_Axis;
        private decimal m_Value;
        private const decimal k_MaxCoordinate = 180;
        public decimal MaxCoordinate
        {
            get
            {
                return k_MaxCoordinate;
            }
        }

        public decimal MinCoordinate
        {
            get
            {
                return -k_MaxCoordinate;
            }
        }

        public decimal Value
        {
            get
            {
                return m_Value;
            }
            set
            {
                if (value >= MinCoordinate && value <= MaxCoordinate)
                {
                    m_Value = value;
                }
                else
                {
                    throw new ArgumentException($"Coordinate value" +
                    $" must be within the range of {MaxCoordinate}-{MinCoordinate}");
                }
            }
        }

        public char Axis
        {
            get 
            {
                return m_Axis;
            }
            set 
            {
                if (char.IsUpper(value))
                {
                    m_Axis = value;
                }
                else 
                {
                    throw new FormatException("Axis value must be a capital letter such as X,Y,Z ...");
                }
            }
        }

        //___Operations___

        public decimal Distance(Coordinate i_Other)
        {
            return Math.Abs(m_Value - i_Other.Value);
        }

        public static decimal Average(params Coordinate[] i_Others)
        {
            decimal avg = 0;
            decimal elementsCount = i_Others.Length;
            foreach (Coordinate coor in i_Others)
            {
                avg += coor.Value / elementsCount;
            }
            return avg;
        }
    }
}
