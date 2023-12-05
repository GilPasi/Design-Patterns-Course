using System;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class UserCard
    {
        protected TableLayoutPanel m_table;
        protected User m_User;
        public TableLayoutPanel Table
        {
            get 
            {
                return m_table;
            }
            set 
            {
                if (value?.ColumnCount != 2 || value?.RowCount != 1)
                {
                    throw new ArgumentException("UserCard object can be appended to a 2X1 tables solely");
                }
                Utilities.AssignToReadOnlyClass(ref m_table, value);
            }
        }

        public User User
        {
            get
            {
                return m_User;
            }
            set
            {
                Utilities.AssignToReadOnlyClass(ref m_User, value);
            }
        }

        public UserCard(TableLayoutPanel i_Table = null, User i_User = null)
        {
            Table = i_Table;
            User = i_User;
        }

        private void setResidence(int i_Line)
        {
            ShoveTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Residence"));
            string resName = m_User?.Location?.Name;
            ShoveTextInCell(i_Column: 1, i_Row: i_Line, resName);
        }

        private void setAge(int i_Line)
        {
            ShoveTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Age"));
            ShoveTextInCell(i_Column: 1, i_Row: i_Line, calcAge(DateTime.Parse(User?.Birthday)).ToString("F1"));
        }

        private void setBirthday(int i_Line)
        {
            if (User.Birthday == null)
            {
                return;//Ignore if not exist
            }
            string birthday = formatBirthDay(User.Birthday);
            string[] possibleFormats = DateTime.Parse(birthday).GetDateTimeFormats();
            string birthdayLiteral = possibleFormats[1];
            ShoveTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Birthday"));
            ShoveTextInCell(i_Column: 1, i_Row: i_Line, formatBirthDay(birthdayLiteral));
        }

        private void setGender(int i_Line)
        {
            ShoveTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Gender"));
            ShoveTextInCell(i_Column: 1, i_Row: i_Line, User?.Gender.ToString());
        }

        private void setName(int i_Line)
        {
            ShoveTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Name"));
            ShoveTextInCell(i_Column: 1, i_Row: i_Line, User?.Name);
        }

        private string nameToFieldReformat(string i_Name)
        {
            if (string.IsNullOrEmpty(i_Name))
            {
                return i_Name;
            }
            string reformatted = i_Name.ToLower();
            reformatted = reformatted[0].ToString().ToUpper()
                + (reformatted.Length > 1 ? reformatted.Substring(1) : string.Empty);
            return $"{reformatted}:"; 
        }

        //This implementation may not suit future needs
        public virtual void ForceLoad()
        {
            if (m_table != null && m_User != null)
            {
                int i = 0;
                setName(i++);
                setGender(i++);
                setBirthday(i++);
                setAge(i++);
                setResidence(i++);
            }
        }

        private float calcAge(DateTime i_BirthDate)
        {
            DateTime currentDate = DateTime.Now;
            const float k_MonthsCount = 12;
            float monthsToAdd = (currentDate.Month - i_BirthDate.Month) / k_MonthsCount;
            float res = currentDate.Year - i_BirthDate.Year;
            res += monthsToAdd;
            return res;
        }

        private string formatBirthDay(string io_UnformattedBirthday)
        {
            //Swapping months and days to fit the DateTime format
            char[] unformattedBirthdayAsArr = io_UnformattedBirthday.ToArray();
            Utilities.SwapInArray(ref unformattedBirthdayAsArr, 0, 3);
            Utilities.SwapInArray(ref unformattedBirthdayAsArr, 1, 4);
            return new string(unformattedBirthdayAsArr);
        }

        protected void ShoveTextInCell(int i_Column, int i_Row, string i_TextToSet)
        {
            /*This method is similar to SetTextInCell(), but it also forces the table
             to grow if there is not enough room. This way, this method cannot throw
            a NullPointerReference from the cell object.*/

            Utilities.AssertPositive(i_Column);
            Utilities.AssertPositive(i_Row);
            assertTableRow(i_Row);
            m_table.GetControlFromPosition(column: i_Column, row: i_Row).Text = i_TextToSet;
        }

        private void assertTableRow(int i_Index)
        {
            for (int i = 0; i < Table.ColumnCount; i++)
            {
                if (m_table.GetControlFromPosition(column: i, row: i_Index) == null)
                {
                    m_table.Controls.Add(new Label(), i, i_Index);
                }
            }
        }
    }
}
