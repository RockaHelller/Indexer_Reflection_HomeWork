using Indexer_Reflection_Homework.Controllers;
using Indexer_Reflection_Homework.Models;
using Indexer_Reflection_Homework.Service;
using Indexer_Reflection_Homework.Service.Interfaces;
using System.Reflection;


#region ClassTask
//PersonController.GetPersonDatas();

//BookController.GetBookData();

//EmployeeController.GetDatas();

//NameController.GetStringNameCountSquare();

//Console.WriteLine(GetBook());

//static string GetBook()
//{
//    Book book = new Book() { BookName = "Xosrov ve Shirin", Author = "Nizami"};

//    //return book.BookName + "-" + book.Author;
//    return book.ToString();
//}
#endregion

#region OperatorOverloading
//Person person1 = new();
//person1.Age = 18;
//Person person2 = new();
//person2.Age = 28;

//Console.WriteLine(person1 > person2);
//Console.WriteLine(person1 < person2);
#endregion

#region Indexer
//List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

//Console.WriteLine(nums[1]);


Book book1 = new Book() { BookName = "Xosrov1", Author = "Nizami1" };
Book book2 = new Book() { BookName = "Xosrov2", Author = "Nizami2" };
Book book3 = new Book() { BookName = "Xosrov3", Author = "Nizami3" };


Library library = new();

library[0] = book1;
library[1] = book2;
library[2] = book3;


Console.WriteLine(library[0].BookName + " - " + library[0].Author);
Console.WriteLine(library[1].BookName + " - " + library[1].Author);
Console.WriteLine(library[2].BookName + " - " + library[2].Author);

#endregion









#region Reflection
Assembly assembly = Assembly.GetExecutingAssembly();

foreach (var item in assembly.GetTypes())
{
    Console.WriteLine(item);
}

foreach (var item in assembly.GetTypes())
{
    foreach (var item1 in item.GetMembers())
    {
        Console.WriteLine(item1);
    }
}
#endregion