using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Applicant : Human
    {
        public float TotalZNOPoints { get; set; }
        public float NumberOfPointsForAnEducationDocument{ get; set; }
        public string NameOfInstitution { get; set; }

        public Applicant(string name, string surname, DateTime birthdate, float totalZNOPoints, float numberOfPointsForAnEducationDocument,string nameOfInstitution) 
            : base(name, surname, birthdate)
        {
            TotalZNOPoints = totalZNOPoints;
            NumberOfPointsForAnEducationDocument = numberOfPointsForAnEducationDocument;
            NameOfInstitution = nameOfInstitution;
        }

        public override string ShowInfo()
        {
            return $"{Name} {SurName} {BirthDate.ToShortDateString()} {TotalZNOPoints} {NumberOfPointsForAnEducationDocument} {NameOfInstitution}";
        }
    }
}
