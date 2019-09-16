using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            //Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            //MatchCollection matches = pattern.Matches(Console.ReadLine());

            string pattern = @"\b([A-Z]{1}[a-z]+) ([A-Z]{1}[a-z]+)\b";

            string names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, pattern);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
