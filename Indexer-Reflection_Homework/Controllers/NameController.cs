using Indexer_Reflection_Homework.Service;
using Indexer_Reflection_Homework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Controllers
{
    public class NameController
    {
        public static void GetStringNameCountSquare()
        {
            INameService nameService = new NameService();

            string word = "C";

            var result = nameService.GetFilteredDatasCount(m => m.Name.ToLower().StartsWith(word.ToLower()));

            Console.WriteLine(result);

        }
    }
}
