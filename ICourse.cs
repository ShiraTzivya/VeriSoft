using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriSoft
{
    internal interface ICourse
    {
        #region Properties
        List<Person> Participants { get; } 
        #endregion

        #region Methods
        public void addParticipant(Person person);//adds a person to the course
        public string getParticipants();//returns a list of participants in the course
                                             
        #endregion
    }
}
