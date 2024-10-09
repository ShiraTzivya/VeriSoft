using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriSoft
{
    internal abstract class Person
    {
        #region Attributes
        private string name;
        private int age;
        protected string address;
        #endregion

        #region Methods
        public string getName() {  return name; }
        public int getAge() { return age; }
        public string getAddress() { return address; }
        public abstract string getRole(); //returns a String describing the role of the person
        #endregion
    }
}
