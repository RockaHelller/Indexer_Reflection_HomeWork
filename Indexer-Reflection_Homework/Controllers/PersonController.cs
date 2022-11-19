using Indexer_Reflection_Homework.Service;
using Indexer_Reflection_Homework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Controllers
{
    public class PersonController
    {


        public static void GetPersonDatas()
        {
            IPersonService personService = new PersonService();

            var result = personService.GetFullData(m => m.Salary > 1000);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }


    }
}
