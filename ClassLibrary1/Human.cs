using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace ClassLibrary1
{
    public class Human
    {
        public string Name { get; set; }
        public string SurName { get; set; } 

        public DateTime BirthDate { get; set; }

        public Human(string name, string surName, DateTime birthDate)
        {
            Name = name;
            SurName = surName;
            BirthDate = birthDate;
        }
        
        public virtual string ShowInfo()
        {
            return $"{Name} {SurName} {BirthDate.ToShortDateString()}";
        }
    }
}