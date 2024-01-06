using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
      public class Lecturer : Human
    {
        public string Post { set; get; }
        public string DepartamentOf {  set; get; }

        public string HigherEducationInstitution { get; set; }
        public Lecturer(string name,string surname ,DateTime birthDate,string post, string departamentOf, string higherEducationInstitution) : base(name,surname,birthDate)
        {
            Post = post;
            DepartamentOf = departamentOf;
            HigherEducationInstitution = higherEducationInstitution;
        }
        public override string ShowInfo()
        {
            return $"{Name} {SurName} {BirthDate.ToShortDateString()} {Post} {DepartamentOf} {HigherEducationInstitution}";
        }
    }
}
