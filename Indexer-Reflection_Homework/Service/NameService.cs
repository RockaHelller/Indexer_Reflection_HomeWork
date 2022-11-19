using Indexer_Reflection_Homework.Models;
using Indexer_Reflection_Homework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Service
{
    public class NameService : INameService
    {
        public int GetFilteredDatasCount(Predicate<Name1> predicate)
        {
            var data = GetAll();

            var result = data.FindAll(predicate);

            var resultPow = Math.Pow(result.Count, 2);

            return (int)resultPow;
        }

        private List<Name1> GetAll()
        {
            List<Name1> name1s = new List<Name1>(); 

            Name1 person1 = new()
            {
                Name = "Cad",
            };

            Name1 person2 = new()
            {
                Name = "cads",
            };

            Name1 person3 = new()
            {
                Name = "caaa",
            };

            Name1 person4 = new()
            {
                Name = "Murad",
            };

            name1s.Add(person1);
            name1s.Add(person2);
            name1s.Add(person3);
            name1s.Add(person4);


            return name1s;
        }


    }
}
