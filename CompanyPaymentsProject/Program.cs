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
            Company company = new Company();

            //na konsoli będzie można podać Id pracownika i wtedy w odpowiedzi suma wypłaconych pieniędzy
            
            Console.WriteLine("Please enter the worker ID number to find out the worker salary.");
            int userID = int.Parse(Console.ReadLine());

            company.AddPayCheck(userID);

            // możliwość dodawania pracowników
            company.AddPerson(new Person {PersonID = 1, Name = "Jan", Surname = "Kowalski", Post.Assistant });
            company.AddPerson(new Person {PersonID = 2, Name = "Anna", Surname = "Nowak", Post.Junior,});
            company.AddPerson(new Person { PersonID = 3, Name = "John", Surname = "Doe", Post.Manager });

            // data obecnej wypłaty
            Paycheck paycheck = new Paycheck();
            Paycheck.ReturnDate();

            

            Console.ReadKey();
        }
    }
}
