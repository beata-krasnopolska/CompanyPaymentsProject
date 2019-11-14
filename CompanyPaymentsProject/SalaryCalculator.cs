using System;
using System.Linq;

namespace CompanyPaymentsProject
{
    class SalaryCalculator
    {
        public decimal CalculateSalary(Post post)
        {
            switch (post)
            { 
                case Post.Assistant:
                    return 200;
                case Post.Junior:
                    return 300;
                case Post.Manager:
                    return 400;
                default:
                    throw new Exception("Post doesn't exist");                    
            }
        }
        public decimal CalculateForOne(Person person)
        {
            return person.Paychecks.Sum(x => x.Salary);
        }
    }
}
