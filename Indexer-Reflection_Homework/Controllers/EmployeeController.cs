using Indexer_Reflection_Homework.Service;
using Indexer_Reflection_Homework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Controllers
{
    public class EmployeeController
    {
        public static void GetDatas()
        {
            IEmployeeService employee = new EmployeeService();

            var result = employee.GetAllBySalary(m => m.Age > 20 && m.Age < 40);

            Console.WriteLine(result);
        }
    }
}
