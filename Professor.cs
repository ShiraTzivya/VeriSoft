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
                // בדיקת ערך null
                if (value == null)
                {
                    throw new ArgumentException("Department cannot be null.");
                }

                // בדיקת ריק
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Department cannot be empty or whitespace.");
                }
                // בדיקה אם המחרוזת מכילה רק אותיות ורווחים
                if (!Regex.IsMatch(value, @"^[a-zA-Z\s]+$"))
                {
                    throw new ArgumentException("Department name can only contain letters and spaces.");
                }

                // בדיקת אורך מינימלי (אם נדרש)
                if (value.Length < 2)
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
            return String.Join(", ", coursesTeach);// returns a String describing the teaching activity
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
