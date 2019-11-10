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
        List<Person> people = new List<Person>()
        {
            new Person { PersonID = 1, Name = "Jan", Surname = "Kowalski", Post.Assistant, Salary = 2000},
            new Person { PersonID = 2, Name = "Anna", Surname = "Nowak", Post.Junior, Salary = 3000},
            new Person { PersonID = 3, Name = "John", Surname = "Doe", Post.Manager, Salary = 4000},
        };
        public void AddNewWorker()
        {
            for (int i = people.Count; i < people.Count+1; i++)
            {
                people[i] = new Person();
                Console.WriteLine("Enter worker #{0} name", i + 1 + people.Count);
                people[i].Name = Console.ReadLine();
                Console.WriteLine("Enter worker #{0} Surname", i + 1 + people.Count);
                people[i].Surname =Console.ReadLine();
                Console.WriteLine("Set the worker post in the company: 1. Manager, 2. Junior, 3. Assistant");
                int workerPost = int.Parse(Console.ReadLine());

                if (workerPost == 1)
                {
                    people[i].Post = Post[0];
                }
                if(workerPost == 2)
                {
                    people[i].Post = Post[1];
                }
                if(workerPost == 3)
                {
                    people[i].Post = Post[2];
                }
            }
        }
    }
}
