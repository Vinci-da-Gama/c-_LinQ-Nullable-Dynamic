using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Nullable_Dynamic_Pj
{
    internal class Exist
    {
        public void ExistByEnter()
        {
            Console.WriteLine("Pls press enter to exist.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {}
        }
        
    }
}
