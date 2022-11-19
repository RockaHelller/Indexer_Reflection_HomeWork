using Indexer_Reflection_Homework.Service;
using Indexer_Reflection_Homework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Controllers
{
    public class BookController
    {
        public static void GetBookData()
        {
            IBookService book = new BookService();

            var result = book.GetName(m => m.Author == "Fizuli");

            Console.WriteLine(result);
        }
    }
}
