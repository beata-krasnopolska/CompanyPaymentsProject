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
            //na konsoli będzie można podać Id pracownika
            //i wtedy w odpowiedzi suma wypłaconych pieniędzy
            
            Console.WriteLine("Please enter the worker ID number to find out the worker salary.");
            int userID = int.Parse(Console.ReadLine());
            
            Company //jak uzyskać dostęp do List z Company??

            // możliwość dodawania pracowników
            
            company.AddNewWorker();

            Console.ReadKey();
        }
    }
}
