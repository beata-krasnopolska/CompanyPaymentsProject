using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPaymentsProject
{
    class Paycheck
    {
        //data wypłaty i kwota
        public static void ReturnDate()
        { 
            DateTime paymentDate = DateTime.Now;
            var firstDayOfMonth = new DateTime(paymentDate.Year, paymentDate.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            Console.WriteLine("The period of current salary is: {0} - {1}", firstDayOfMonth.ToString("d"), lastDayOfMonth.ToString("d"));
        }

        public void SalaryDeductions(int salary)
        {
            int socSec = salary* 8%;
            int medcare = salary * 10%;

            Console.WriteLine("Salary: {0} ; Social Security: {1}", salary, socSec);
            Console.WriteLine("Salary: {0} ;Medcare: {1}", salary, medcare);
        }
        
        public void SalaryGrossNet(int salary)
        {
            int netSalary = salary + salary*25%;

            Console.WriteLine("The Net Salary: {0}, Gross Salary: {1}", netSalary, salary);
        }
       
    }
}
