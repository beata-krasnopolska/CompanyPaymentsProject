
namespace CompanyPaymentsProject
{
    class SalaryCalculator
    {
        public int Salary { get; set; }

        public decimal CalculateSalary(Post post)
        {
            switch (post)
            { 
                case Post.Assistant:
                    Salary = 200;
                    break;
                case Post.Junior:
                    Salary = 300;
                    break;
                case Post.Manager:
                    Salary = 400;
                    break;
                default:
                    break;
            }
            return Salary;
        }
    }
}
