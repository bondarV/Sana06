
using ClassLibrary1;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Human[] peoples = new Human[5];
peoples[0] = new Human("Vitaliy", "Bondar", new DateTime(2006, 07, 03));
peoples[1] = new Applicant("Valentun","Bilyy",new DateTime(2000,10,12),190.5F,195F,"ZTU");
peoples[2] = new Lecturer("Oleksii", "Chyzmotrya", new DateTime(1976, 10, 2), "teacher", "FIKT", "ZTU");
peoples[3] = new Student("Yaroslav", "Nikonchyl", new DateTime(2006, 11, 12), 1, "IPZ 23-4", "FIKT", "ZTU");
peoples[4] = new LibraryUser("Yura", "Malyi", new DateTime(2000, 2, 1), 134511, new DateTime(2024, 01, 05), 500);

for (int i = 0; i < peoples.Length; i++)
{
Console.WriteLine(peoples[i].ShowInfo());
    if (i + 1 != peoples.Length) Console.WriteLine();
}


