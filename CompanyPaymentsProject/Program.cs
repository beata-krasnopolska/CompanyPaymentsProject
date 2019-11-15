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
            
            company.AddPerson(new Person { PersonID = 1, Name = "Jan", Surname = "Kowalski", Post = Post.Assistant });
            company.AddPerson(new Person { PersonID = 2, Name = "Anna", Surname = "Nowak", Post = Post.Junior });
            company.AddPerson(new Person { PersonID = 3, Name = "John", Surname = "Doe", Post = Post.Manager });
            
            company.AddPayCheck(1, new DateTime(1998, 1, 1));
            company.AddPayCheck(1, new DateTime(1999, 1, 1));
            company.AddPayCheck(3, new DateTime(2001, 1, 1));
            company.AddPayCheck(3, new DateTime(1999, 2, 2));
            company.AddPayCheck(3, new DateTime(2000, 1, 1));
            
            Console.WriteLine("Please enter the employee ID number to find out the salary.");
            int userID = int.Parse(Console.ReadLine());

            var employeeSalary = company.GetPerson(userID);
            Console.WriteLine("The employee ID: {0},    salary: {1}", userID, employeeSalary);

            Console.ReadKey();
        }
    }
}
