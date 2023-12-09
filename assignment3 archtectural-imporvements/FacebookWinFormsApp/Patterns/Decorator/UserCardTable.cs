using System;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using System.Linq;
using BasicFacebookFeatures.Patterns.Decorator;
using System.Collections.Generic;
namespace BasicFacebookFeatures
{
    public class UserCardTable : UserCardDecorator
    {
        private TableLayoutPanel m_table;
        private UserCardMixin m_InnerDecorator;
        protected Utilities.Asserter Asserter 
        { get; } = new Utilities.Asserter();
        //Shall not be altered throughout the run

        public UserCardTable(UserCardMixin i_InnerDecorator)
        {
            AssertInnerDecorator(i_InnerDecorator);
            m_InnerDecorator = i_InnerDecorator;
        }

        public override UserCardMixin InnerDecorator
        {
            get
            {
                return m_InnerDecorator;
            }
        }

        public override User DataUser
        {
            get
            {
                return InnerDecorator.DataUser;
            }
        }

        public float UserAge
        { 
            get
            {
                return calcAge(DataUser.Birthday);
            }
        }

        public string Residence
        { 
            get
            {
                return DataUser.Location.Name;
            }
        }

        public List<Group> Groups
        {
            get
            {
                return new List<Group>(DataUser.Groups.ToArray());
            }
        }

        public override Control UiComponent
        {
            get
            {
                return m_table;
            }
            set
            {
                Utilities.AssertType(value, typeof(TableLayoutPanel));
                Control tableAsControl = m_table;
                Utilities.AssignToReadOnlyClass(ref tableAsControl, value);
                m_table = tableAsControl as TableLayoutPanel;
            }
        }

        public TableLayoutPanel Table
        {
            //Essentially the same thing as the UiComponent, just add to the readability
            get
            {
                return UiComponent as TableLayoutPanel;
            }
        }

        public override void AssignData(bool i_IgnoreVacancy = true)
        {
            InnerDecorator.Load(i_IgnoreVacancy);
            if (m_table != null && InnerDecorator.DataUser != null)
            {
                int i = 0;
                setGender(i++, i_IgnoreVacancy);
                setBirthday(i++, i_IgnoreVacancy);
                setAge(i++, i_IgnoreVacancy);
                setResidence(i++, i_IgnoreVacancy);
            }
        }

        private void setResidence(int i_Line, bool i_IgnoreVacancy = true)
        {
            if (checkIfCellIsOverrideable(i_Line, i_IgnoreVacancy))
            {
                SetTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Residence"));
                string resName = InnerDecorator.DataUser?.Location?.Name;
                SetTextInCell(i_Column: 1, i_Row: i_Line, resName);
            }
        }

        private void setAge(int i_Line, bool i_IgnoreVacancy = true)
        {
            if (checkIfCellIsOverrideable(i_Line, i_IgnoreVacancy))
            {
                SetTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Age"));
                if (!string.IsNullOrEmpty(DataUser.Birthday))
                {
                    float age = calcAge(DataUser.Birthday);
                    SetTextInCell(i_Column: 1, i_Row: i_Line, age.ToString("F1"));
                }
            }
        }

        private void setBirthday(int i_Line, bool i_IgnoreVacancy = true)
        {
            if (DataUser.Birthday == null)
            {
                return;//Ignore if not exist
            }

            if (checkIfCellIsOverrideable(i_Line, i_IgnoreVacancy))
            {
                string birthday = formatBirthDay(DataUser.Birthday);
                string[] possibleFormats = DateTime.Parse(birthday).GetDateTimeFormats();
                string birthdayLiteral = possibleFormats[1];
                SetTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Birthday"));
                SetTextInCell(i_Column: 1, i_Row: i_Line, formatBirthDay(birthdayLiteral));
            }
        }

        private void setGender(int i_Line, bool i_IgnoreVacancy = true)
        {
            if (checkIfCellIsOverrideable(i_Line, i_IgnoreVacancy))
            {
                SetTextInCell(i_Column: 0, i_Row: i_Line, nameToFieldReformat("Gender"));
                SetTextInCell(i_Column: 1, i_Row: i_Line, DataUser?.Gender.ToString());
            }
        }

        private bool checkIfCellIsOverrideable(int i_Line, bool i_IgnoreVacancy)
        {
            return !i_IgnoreVacancy || Table.GetControlFromPosition(column: 0, row: i_Line) == null;
        }

        protected void SetTextInCell(int i_Column, int i_Row, string i_TextToSet)
        {
            Asserter.AssertPositive(i_Column, i_Row);
            if (!CheckIfCellExist(i_Column, i_Row))
            {
               SoftExpandTable(i_Column + 1, i_Row + 1);
            }

            Table.GetControlFromPosition(column: i_Column, row: i_Row).Text = i_TextToSet;
        }

        protected bool CheckIfCellExist(int i_Column, int i_Row)
        {
            Asserter.AssertPositive(i_Column, i_Row);
            return Table.GetControlFromPosition(i_Column, i_Row) != null;
        }

        protected void SoftExpandTable(int i_Column, int i_Row)
        {
            Asserter.AssertPositive(i_Column, i_Row);
            for (int i = 0; i < i_Row; i++)
            {
                softRowExpand(i);
            }

            for (int i = 0; i < i_Column; i++)
            {
                softColumnExpand(i);
            }
        }

        private void softRowExpand(int i_Row)
        {
            /*Note that this method does not override previous values*/
            for (int i = 0; i < Table.ColumnCount; i++)
            {
                if (Table.GetControlFromPosition(column: i, row: i_Row) == null)
                {
                    Table.Controls.Add(new Label(), i, row: i_Row);
                }
            }
        }

        private void softColumnExpand(int i_Column)
        {
            /*Note that this method does not override previous values*/
            for (int i = 0; i < Table.RowCount; i++)
            {
                if (Table.GetControlFromPosition(column: i_Column, row: i) == null)
                {
                    Table.Controls.Add(new Label(), i_Column, row: i);
                }
            }
        }

        //___Minor Methods___//

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

        private float calcAge(string i_BirthDate)
        {
            string formattedBirthday = formatBirthDay(i_BirthDate);
            return calcAge(DateTime.Parse(formattedBirthday));
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

    }
}
