using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Nullable_Dynamic_Pj.NullableClasses
{
    internal class Nullable_Ops
    {
        public static void ShowNullableDates()
        {
            DateTime? date = new DateTime(2018, 2, 15);
            DateTime date0 = date.GetValueOrDefault();
            DateTime? date1 = date0;
            Console.WriteLine($"\ndate1 is: {date1}.");

            DateTime? d2 = null;
            DateTime d3 = d2 ?? DateTime.Today;
            DateTime d4 = (d2 != null) ? d2.GetValueOrDefault() : d3;
            Console.WriteLine($"d4 is: {d4}.");
        }
    }
}
