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
            //Було б доцільніше зробити вивід числа 190.5 без коми,але це не є метою цього завдання
            return $"Об'єкт класу Applicant\nІм'я:{Name},прізвище:{SurName},дата народження:{BirthDate.ToShortDateString()},кількість балів сертифікатів ЗНО:{TotalZNOPoints},кількість балів за документ про освіту:{NumberOfPointsForAnEducationDocument},назва загальноосвітнього навчального закладу:{NameOfInstitution}";
        }
    }
}
