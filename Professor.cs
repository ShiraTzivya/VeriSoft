using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VeriSoft
{
    internal class Professor : Person
    {
        #region Attributes
        private string department;
        private List<string> coursesTeach = new List<string>();

        #endregion

        #region Properties
        public string Department
        {
            get { return department; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // בדיקת שהערך לא ריק ולא מכיל רק רווחים
                {
                    throw new ArgumentException("Department cannot be empty or whitespace.");
                }
                if (!Regex.IsMatch(value, @"^[a-zA-Zא-ת\s]+$"))// בדיקה אם המחרוזת מכילה רק אותיות ורווחים
                {
                    throw new ArgumentException("Department name can only contain letters and spaces.");
                }
                if (value.Length < 2)// בדיקת אורך מינימלי
                {
                    throw new ArgumentException("Department name must be at least 2 characters long.");
                }

                department = value;
            }

        }
        #endregion

        #region Methods
        public override string getRole()
        {
            return "Professor";
        }
        public string teach()
        {
            return String.Join(", ", coursesTeach);// מחזיר את רשימת הקורסים שהוא מלמד
        }
        public void addCourseTeach(string courseTeach)
        {
            coursesTeach.Add(courseTeach);
        }
        #endregion

        #region Ctor
        public Professor(string name, int birthYear, string address,string department) : base(name, birthYear, address)
        {
            Department=department;
        }
        #endregion
    }
}
