using Indexer_Reflection_Homework.Models;
using Indexer_Reflection_Homework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Service
{
    public class EmployeeService : IEmployeeService
    {
        public double GetAllBySalary(Predicate<Employee> predicate)
        {
            var data = GetAll();

            var result = data.FindAll(predicate);

            return GetAverage(result);

        }

        private List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { Age = 23, Salary = 4500});
            employees.Add(new Employee { Age = 28, Salary = 3500});
            employees.Add(new Employee { Age = 39, Salary = 500});
            employees.Add(new Employee { Age = 19, Salary = 9800});
            employees.Add(new Employee { Age = 16, Salary = 300});

            return employees;
        }

        private double GetAverage(List<Employee> employees)
        {
            var sum = employees.Average(m => m.Salary);
            return sum;
        }
    }
}
