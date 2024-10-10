using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VeriSoft
{
    internal abstract class Person
    {
        #region Attributes
        private string name;
        private int birthYear;//בשביל לדעת מה הגיל תמיד
        protected string address;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrWhiteSpace(value))//בדיקה שהשם לא ריק ולא רק רווחים
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                if (!Regex.IsMatch(value, @"^[a-zA-Zא-ת\s]+$"))//בדיקה שהשם מכיל רק אותיות ורווחים
                {
                    throw new ArgumentException("Department name can only contain letters and spaces.");
                }
                if (value.Length < 2)//בדיקה שאורך השם גדול מ-2
                {
                    throw new ArgumentException("Department name must be at least 2 characters long.");
                }
                name = value;
            }
        }
        public int BirthYear
        {
            set
            {
                int currentYear = DateTime.Now.Year;
                // בדיקה שהשנת הלידה הגיונית
                if (value < 1900 || value > currentYear - 1)
                {
                    throw new ArgumentException("Birth year must be between 1900 and the current year.");
                }
                birthYear = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                // בדיקה שהכתובת לא ריקה ולא מכחיה רק רווחים
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Address cannot be empty or whitespace.");
                }

                // בדיקת אורך מינימלי
                if (value.Length < 5)
                {
                    throw new ArgumentException("Address must be at least 5 characters long.");
                }

                // בדיקה לתווים הגיוניים בכתובת
                string pattern = @"^[a-zA-Z0-9\s,.]+$"; 
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentException("Address contains invalid characters.");
                }

                address = value;
            }
        }
        #endregion

        #region Methods
        public int getAge() { return DateTime.Now.Year-birthYear; }
        public abstract string getRole(); //returns a String describing the role of the person
        #endregion

        #region Ctor
        protected Person(string name,int birthYear, string address) 
        { 
            Name = name;
            BirthYear = birthYear;
            Address = address;
        }
        #endregion

    }
}
