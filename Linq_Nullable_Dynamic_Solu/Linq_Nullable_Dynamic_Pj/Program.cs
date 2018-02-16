﻿using System;
using System.Linq;
using System.Threading;
using Linq_Nullable_Dynamic_Pj.LinqClasses;

namespace Linq_Nullable_Dynamic_Pj
{
    class Program
    {
        static void Main(string[] args)
        {
            var BookList = new BookCollection().GetBooks();
            var cheapBooks = BookList.Where(b => b.Price < 10).OrderBy(bk => bk.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine($"Book: {book.Title} -- Price: {book.Price}.");
            }

            // Linq-Query and Linq-Expression are same;
            // Linq-Query:
            /* var b0 = from b in BookList
                     where b.Price < 10
                     orderby b.Title
                     select b.Title; */
            // Linq-Expression:
            /* var b1 = BookList.Where(b => b.Price < 10).OrderBy(bk => bk.Title).Select(b => b.Title); */

            // last 3 in Linq Expression
            dynamic Last3 = BookList.Skip(2).Take(3);
            Console.WriteLine($"Take 1s to jump over 2 books...");
            Thread.Sleep(1000);
            foreach (var l3b in Last3)
            {
                Console.WriteLine($"Book: {l3b.Title} -- Price: {l3b.Price}.");
            }



            Exist exi = new Exist();
            exi.ExistByEnter();
        }
    }
}
