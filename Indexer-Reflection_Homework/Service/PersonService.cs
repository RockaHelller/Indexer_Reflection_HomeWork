using Indexer_Reflection_Homework.Models;
using Indexer_Reflection_Homework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Service
{
    public class PersonService : IPersonService
    {
        public List<string> GetFullData(Predicate<Person> predicate)
        {


            var people = GetAll();

            var result = people.FindAll(predicate);

            return GetPersonDetails(result);


        }

        private List<Person> GetAll()
        {
            List<Person> people = new List<Person>();

            Person person1 = new()
            {
                Name = "Murad",
                Surname = "Jafarov",
                Address = "NZS",
                Salary = 5000
            };

            Person person2 = new()
            {
                Name = "Musa",
                Surname = "Afandiyev",
                Address = "Xalqlar",
                Salary = 4750
            };

            Person person3 = new()
            {
                Name = "Cavid",
                Surname = "Bashirov",
                Address = "Ahmadli",
                Salary = 8000
            };

            Person person4 = new()
            {
                Name = "Rasul",
                Surname = "Hasanov",
                Address = "Xalqlar",
                Salary = 750
            };

            Person person5 = new()
            {
                Name = "Gultac",
                Surname = "Jafarov",
                Address = "Tbilisi",
                Salary = 980
            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            return people;
        }

        private List<string> GetPersonDetails(List<Person> people)
        {
            List<string> fullDatas = new();

            foreach (var item in people)
            {
                string data = $"{item.Name} - {item.Surname} - {item.Address}";
                fullDatas.Add(data);
            }

            return fullDatas;
        }

    }


}
