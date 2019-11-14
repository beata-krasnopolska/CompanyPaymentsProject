using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPaymentsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            
            // możliwość dodawania pracowników
            company.AddPerson(new Person {PersonID = 1, Name = "Jan", Surname = "Kowalski", Post.Assistant });
            company.AddPerson(new Person {PersonID = 2, Name = "Anna", Surname = "Nowak", Post.Junior,});
            company.AddPerson(new Person { PersonID = 3, Name = "John", Surname = "Doe", Post.Manager });
            
            // dodanie wypłat dla pracowników
            company.AddPayCheck(1);
            company.AddPayCheck(1);
            company.AddPayCheck(3);
            company.AddPayCheck(3);
            company.AddPayCheck(3);

            //na konsoli będzie można podać Id pracownika i wtedy w odpowiedzi suma wypłaconych pieniędzy
            Console.WriteLine("Please enter the employee ID number to find out the salary.");
            int userID = int.Parse(Console.ReadLine());            

            Console.ReadKey();
        }
    }
}
