using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPaymentsProject
{
    class Company : Person
    {
        Paycheck paycheck = new Paycheck();
        //lista osób i możliwość ich dodawania
        private List<Person> _persons = new List<Person>();
       
        public List<Person> GetPersonList()
        {
            return _persons;
        }

        public List<Paycheck> Paychecks = new List<Paycheck>();

        //Id pracownika jako parametr - dodaje dla niego jakąś wypłątę
        public void AddPayCheck(int personId)
        {
            var person = _persons.Where(x => x.PersonID == personId);            
            var salary = new SalaryCalculator().CalculateSalary(Post);
            Paychecks.Add(new Paycheck { Salary = salary });
        }

        public void AddPerson(Person person)
        {
            for (int i = _persons.Count; i < _persons.Count+1; i++)
            {
                _persons[i] = new Person();
                Console.WriteLine("Enter worker #{0} first name:", i + 1 + _persons.Count);
                _persons[i].Name = Console.ReadLine();
                Console.WriteLine("Enter worker #{0} family name:", i + 1 + _persons.Count);
                _persons[i].Surname =Console.ReadLine();
                Console.WriteLine("Set the worker post in the company: 1. Manager, 2. Junior, 3. Assistant");
                int workerPost = int.Parse(Console.ReadLine());

                if (workerPost == 1)
                {
                    _persons[i].Post = Post[0];
                }
                if(workerPost == 2)
                {
                    _persons[i].Post = Post[1];
                }
                if(workerPost == 3)
                {
                    _persons[i].Post = Post[2];
                }
            }
        }
    }
}
