using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Nullable_Dynamic_Pj.LinqClasses
{
    internal class BookCollection
    {
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>() {
                new Book { Title = "ADO.Net Step by Step", Price = 5 },
                new Book { Title = "ASP.NET MVC", Price = 9.99 },
                new Book { Title = "ASP.NET Web API", Price = 12 },
                new Book { Title = "C# Advanced Topics", Price = 7 },
                new Book { Title = "C# Advanced Topics", Price = 9 }
            };
            return books;
        }
    }
}
