﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPaymentsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            
            company.AddPerson(new Person { PersonID = 1, Name = "Jan", Surname = "Kowalski", Post = Post.Assistant });
            company.AddPerson(new Person { PersonID = 2, Name = "Anna", Surname = "Nowak", Post = Post.Junior });
            company.AddPerson(new Person { PersonID = 3, Name = "John", Surname = "Doe", Post = Post.Manager });
            
            company.AddPayCheck(1, new DateTime(1998, 1, 1));
            company.AddPayCheck(1, new DateTime(1999, 1, 1));
            company.AddPayCheck(3, new DateTime(2001, 1, 1));
            company.AddPayCheck(3, new DateTime(1999, 2, 2));
            company.AddPayCheck(3, new DateTime(2000, 1, 1));
            
            Console.WriteLine("Please enter the employee ID number to find out the salary.");
            int userID = int.Parse(Console.ReadLine());

            var salaryCalculator = new SalaryCalculator();

            //Returns current employee salary

            var employeeSalary = salaryCalculator.CalculateForOne(company.GetPerson(userID));

            //Employee searcher returns a sum of salary form the time span

            DateTime startDate = new DateTime(1991, 1, 1);
            DateTime endDate = new DateTime(2000, 3, 3);

            var timeSpanSalary = salaryCalculator.GetTimeSpanSalary(company, startDate, endDate, userID);

            Console.WriteLine("The employee ID: {0},    salary: {1}", userID, employeeSalary);
            Console.WriteLine("The employee ID: {0},    time span: {1}  -  {2}    salary: {3}", userID, startDate,
                                                                                                endDate, timeSpanSalary);

            Console.ReadKey();
        }
    }
}
