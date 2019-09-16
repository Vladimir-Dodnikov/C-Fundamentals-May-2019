using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@"\b(?<day>\d{2})(?<delimiter>[-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b");

            var dates = regex.Matches(Console.ReadLine());

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
