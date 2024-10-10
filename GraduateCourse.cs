using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VeriSoft
{
    internal class GraduateCourse : UndergraduateCourse
    {
        #region Attributes
        private string researchFocus;
        #endregion

        #region Properties
        public string ResearchFocus
        {
            get { return researchFocus; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))//בדיקה שהערך לא ריק ולא מכיל רק רווחים
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                if (!Regex.IsMatch(value, @"^[a-zA-Zא-ת\s]+$"))//בדיקת תויים מתאימים
                {
                    throw new ArgumentException("Department name can only contain letters and spaces.");
                }
                if (value.Length < 2) // בדיקת אורך מינימלי 
                {
                    throw new ArgumentException("Department name must be at least 2 characters long.");
                }
            }
        }
        #endregion

        #region Methods
        public override void addParticipant(Person person) { base.addParticipant(person); }
        public override string getParticipants() { return base.getParticipants(); }
        #endregion

        #region Ctor
        public GraduateCourse(string courseName,string researchFocus): base(courseName)
        {
            ResearchFocus=researchFocus;
        }
        #endregion
    }
}
