using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPaymentsProject
{
    class Company : Person
    {
        
        //lista osób i możliwość ich dodawania
        private List<Person> _people = new List<Person>()
        {
            new Person { PersonID = 1, Name = "Jan", Surname = "Kowalski", Post.Assistant, Salary = 2000},
            new Person { PersonID = 2, Name = "Anna", Surname = "Nowak", Post.Junior, Salary = 3000},
            new Person { PersonID = 3, Name = "John", Surname = "Doe", Post.Manager, Salary = 4000},
        };

        public List<Person> GetPersonList()
        {
            return _people;
        }

        public void ReturnSalary(int workerID)
        {
            for (int i = 0; i < _people.Count; i++)
            {
                if (PersonID == workerID)
                {
                    Console.WriteLine("Employee ID : {0} earns: {1}.", workerID, Salary);
                }
            }

        }
        public void AddNewWorker()
        {
            for (int i = _people.Count; i < _people.Count+1; i++)
            {
                _people[i] = new Person();
                Console.WriteLine("Enter worker #{0} name", i + 1 + _people.Count);
                _people[i].Name = Console.ReadLine();
                Console.WriteLine("Enter worker #{0} Surname", i + 1 + _people.Count);
                _people[i].Surname =Console.ReadLine();
                Console.WriteLine("Set the worker post in the company: 1. Manager, 2. Junior, 3. Assistant");
                int workerPost = int.Parse(Console.ReadLine());

                if (workerPost == 1)
                {
                    _people[i].Post = Post[0];
                }
                if(workerPost == 2)
                {
                    _people[i].Post = Post[1];
                }
                if(workerPost == 3)
                {
                    _people[i].Post = Post[2];
                }
            }
        }
    }
}
