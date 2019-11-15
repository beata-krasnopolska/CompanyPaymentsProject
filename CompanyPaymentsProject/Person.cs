using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPaymentsProject
{
    class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int PersonID { get; set; }

        public Post Post { get; set; }

        public List<Paycheck> Paychecks { get; set; }                
    }
}
