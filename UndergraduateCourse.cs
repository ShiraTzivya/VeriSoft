using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriSoft
{
    internal class UndergraduateCourse : Course
    {
        #region Attributes
        private string courseName;
        private string courseCode;
        #endregion

        #region Methods
        public virtual string getCourseName() {  return courseName; }
        public virtual string getCourseCode() {  return courseCode; }
        public virtual void  addParticipant(Person person) { }
        public virtual Person[] getParticipants() { return default(Person[]); }
        #endregion

    }
}
