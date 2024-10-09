using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriSoft
{
    internal class Professor : Person
    {
        #region Attributes
        private string department;
        #endregion

        #region Methods
        public override string getRole()
        {
            return "Professor";
        }
        public string teach()
        {
            return default(string);// returns a String describing the teaching activity
        }
        #endregion
    }
}
