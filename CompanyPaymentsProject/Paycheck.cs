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
        public int PaycheckId { get; set; }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }         
    }
}
