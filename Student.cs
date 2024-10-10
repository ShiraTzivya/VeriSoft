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
        private static int count = 0;//משתנה סטטי המונה את התלמידים ליצירת studentId  
        private List<string> courses = new List<string>();//רשימת הקורסים שהוא לומד
        #endregion

        #region Properties
        public string StudentId
        {
            get { return studentId; }
        }
       
        #endregion

        #region Methods
        public override string getRole()
        {
            return "Student";
        }
        public void addCourse(string curse)
        {
            courses.Add(curse);
        }
        public string study()
        {
            return String.Join(", ", courses);//יצירת מחרוזת של כל הקורסים
        }
        #endregion

        #region Ctor
        public Student(string name, int birthYear, string address): base(name, birthYear, address)
        {
            count++;
            studentId = count.ToString(); 
        }
        #endregion
    }
}
