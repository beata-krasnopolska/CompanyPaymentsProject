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
            
            //na konsoli będzie można podać Id pracownika
            //i wtedy w odpowiedzi suma wypłaconych pieniędzy
            
            Console.WriteLine("Please enter the worker ID number to find out the worker salary.");
            int userID = int.Parse(Console.ReadLine());

            // możliwość dodawanai pracowników
            Company company = new Company();
            company.AddNewWorker();

            Console.ReadKey();
        }
    }
}
