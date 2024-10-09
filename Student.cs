using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriSoft
{
    internal class Student : Person
    {
        #region Attributes
        private string studentId;
        #endregion

        #region Methods
        public override string getRole()
        {
            return "Student";
        }
        public string study()// returns a String describing the study activity
        {
            return default(string);
        }
        #endregion
    }
}
