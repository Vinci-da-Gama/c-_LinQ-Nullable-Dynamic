using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Nullable_Dynamic_Pj.Dynamic
{
    internal class DyanmicVariables
    {
        public static void ShowDynamicVariables()
        {
            dynamic a = "collin";
            a = 10;

            dynamic b = 3;
            dynamic c = 3;
            int d = b + c;

            Console.WriteLine($"\na is: {a} -- d is: {d}.");
        }
    }
}
