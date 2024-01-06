using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student :Human
    {
        public byte Course { get; set; }
        public string Group { get; set; }

        public string Faculty { get; set; }
        public string HigherEducationInstitution { get; set; }

        public Student(string name, string surName , DateTime birthDate,byte course, string group ,string faculty,string higherEducationInstitution )
            : base(name, surName, birthDate)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            HigherEducationInstitution = higherEducationInstitution;
        }

        public override string ShowInfo()
        {
            return $"{Name} {SurName} {BirthDate.ToShortDateString()} {Course} {Group} {Faculty} {HigherEducationInstitution}";
        }
    }
}
