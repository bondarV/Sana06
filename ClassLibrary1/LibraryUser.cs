using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibraryUser : Human
    {
        public int NumberOfLibraryCard { get; set; }
        public DateTime TimeOfIssue { get; set; }
        public double TheSizeOfTheMonthlyReaderContribution { get; set; }

        public LibraryUser(string name, string surName, DateTime birthDate, int numberOfLibraryCard, DateTime timeOfIssue, double theSizeOfTheMonthlyReaderContribution)
            : base(name, surName, birthDate)
        {
            NumberOfLibraryCard = numberOfLibraryCard;
            TimeOfIssue = timeOfIssue;
            TheSizeOfTheMonthlyReaderContribution = theSizeOfTheMonthlyReaderContribution;
        }
        public override string ShowInfo()
        {
            return $"Об'єкт класу LibraryUser\nІм'я:{Name},прізвище:{SurName},дата народження:{BirthDate.ToShortDateString()},номер читацького квитка:{NumberOfLibraryCard},дата видачі:{BirthDate.ToShortDateString()},розмір щомісячного читацького внеску:{TheSizeOfTheMonthlyReaderContribution} грн.";
        }
    }


}
