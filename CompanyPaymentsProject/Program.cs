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

            company.ReturnSalary(userID);

            // możliwość dodawania pracowników
            
            company.AddNewWorker();

            // data obecne wypłaty
            Paycheck paycheck = new Paycheck();
            Paycheck.ReturnDate();

            Console.WriteLine("Would you line to know the deductions of your salary please enter the salary");
            int salary = int.Parse(Console.ReadLine());
            paycheck.SalaryDeductions(salary);

            Console.ReadKey();
        }
    }
}
