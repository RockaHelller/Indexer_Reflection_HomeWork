using Indexer_Reflection_Homework.Models;
using Indexer_Reflection_Homework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Service
{
    public class BookService : IBookService
    {
        public int GetName(Predicate<Book> predicate)
        {
            var author = GetBook();

            var result = author.FindAll(predicate).Count;

            return result;

        }

        private List<Book> GetBook()
        {
            List<Book> books = new List<Book>();

            Book book1 = new Book()
            {
                BookName = "Iskendername",
                Author = "Nizami"
            };

            Book book2 = new Book()
            {
                BookName = "Shikayetname",
                Author = "Fizuli"
            };

            Book book3 = new Book()
            {
                BookName = "Xosrov ve Shirin",
                Author = "Nizami"
            };

            Book book4 = new Book()
            {
                BookName = "Ferhad ve Shirin",
                Author = "Fizuli"
            };

            Book book5 = new Book()
            {
                BookName = "Sevil",
                Author = "Huseyn Cavid"
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            return books;


        }
    }
}
