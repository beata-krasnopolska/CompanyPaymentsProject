using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPaymentsProject
{
    class Company
    {
        private List<Person> _persons = new List<Person>();
       
        public List<Person> GetPersonList()
        {
            return _persons;
        }

        public void AddPayCheck(int personId, DateTime date)
        {
            var person = _persons.SingleOrDefault(x => x.PersonID == personId);            
            var salary = new SalaryCalculator().CalculateSalary(person.Post);
            person.Paychecks.Add(new Paycheck { Salary = salary });
            person.Paychecks.Add(new Paycheck { Date = date });
        }

        public Person GetPerson(int personId)
        {
            return _persons.SingleOrDefault(x => x.PersonID == personId);
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }
    }
}
