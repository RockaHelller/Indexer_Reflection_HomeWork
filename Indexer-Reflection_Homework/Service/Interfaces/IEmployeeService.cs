using Indexer_Reflection_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Service.Interfaces
{
    public interface IEmployeeService
    {
        double GetAllBySalary(Predicate<Employee> predicate);
    }
}
