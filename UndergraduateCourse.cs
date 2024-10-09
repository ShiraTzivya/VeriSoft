using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VeriSoft
{
    internal class UndergraduateCourse : ICourse
    {
        #region Attributes
        private string courseName;
        private string courseCode;
        private static int count = 0;
        private List<Person> participants = new List<Person>();
        
        #endregion

        #region Properties
        public string CourseName
        { 
            get { return courseName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                courseName = value;
            }
        }
        public string CourseCode
        {
            get { return courseCode; }
        }
        public List<Person> Participants { get; }

        #endregion

        #region Methods
        public virtual void  addParticipant(Person person) 
        {
            {
                if (person is Student student)
                {
                    participants.Add(student);
                    student.addCourse(courseName);
                }
            ;
            }
        }
        public virtual string getParticipants() 
        {
            return string.Join(", ", participants.Select(p => p.Name));
        }
        #endregion

        #region Ctor
        public UndergraduateCourse(string courseName)
        {
            CourseName=courseName;
            count++;
            courseCode = count.ToString();
        }
        #endregion

    }
}
