using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                researchFocus = value;
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
