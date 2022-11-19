using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Homework.Models
{


    public class Book
    {
        public string? Author { get; set; }
        public string? BookName { get; set; }

        public override string ToString()
        {
            return BookName + "-" + Author;
        }
    }
}
