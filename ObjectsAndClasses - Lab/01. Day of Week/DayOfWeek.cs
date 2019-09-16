using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _01._Day_of_Week
{
    class DayOfWeek
    {

        static void Main()
        {
            // how to create new object with standard tempates implemenate in .NetCore
            //DateTime date = new DateTime();
            //DateTime date = new 
            //{
            //    Year = 1999,
            //    Month = 5,
            //    Day = 11
            //};

            //Variant 1 - ne dava tochen rezultat ako ne smenish format-a ot dd-mm-yyyy na d-M-yyyy!
            //DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine(date.DayOfWeek);

            //Variant 2
            //List<int> date = Console.ReadLine()
            //    .Split("-")
            //    .Select(int.Parse)
            //    .ToList();
            //int day = date[0];
            //int month = date[1];
            //int year = date[2];
            //string format = "d-M-yyyy";

            //IFormatProvider provider = CultureInfo.InvariantCulture;

            //DateTime formatDate = new DateTime(year, month, day);

            //Console.WriteLine(formatDate.DayOfWeek);

            //Variant 3
            string input = Console.ReadLine();
            string format = "d-M-yyyy";

            IFormatProvider provider = CultureInfo.InvariantCulture;

            DateTime date = DateTime.ParseExact(input, format, provider);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
