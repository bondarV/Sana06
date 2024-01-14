using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Applicant : Human
    {
        protected float _totalZnoPoints;
        public float TotalZNOPoints
        {
            get {
                return _totalZnoPoints;
            }   
            set
            {
                if (value <= 200 && value >= 100)
                    _totalZnoPoints = value;
                else throw new Exception("Бал ЗНО має бути в межах від 100 до 200 включно");
            }
        }
        float _numberOfPointsForAnEducationDocument;
        public float NumberOfPointsForAnEducationDocument{ 
            get {
               return _numberOfPointsForAnEducationDocument; 
              } set
            {
                if ((value <= 12 && value >= 0) || value <= 200 && value >= 0)
                    _numberOfPointsForAnEducationDocument = value;
                else throw new NumOfPntsForAnEduDocException(value,"Кількість балів за документ про освіту може бути або за системою 200-сот бальною або за шкільною системою"); ;
            }
        }

        public string NameOfInstitution {  get; set; }
      

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
