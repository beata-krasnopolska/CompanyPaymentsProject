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
        public int PersonID { get; set; }
        public decimal Salary { get; set; }

        
        public static void ReturnDate()
        { 
            DateTime paymentDate = DateTime.Now;
            var firstDayOfMonth = new DateTime(paymentDate.Year, paymentDate.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            Console.WriteLine("The period of current salary is: {0} - {1}", firstDayOfMonth.ToString("d"), lastDayOfMonth.ToString("d"));
        }        
    }
}
