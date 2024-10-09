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

        #region Methods
        public override string getCourseName() { return this.getCourseName(); }
        public override string getCourseCode() { return this.getCourseCode(); }
        public override void addParticipant(Person person) { }
        public override Person[] getParticipants() { return default(Person[]); }
        #endregion
    }
}
