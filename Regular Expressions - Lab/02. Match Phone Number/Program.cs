using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"(\+| )[359]+( |-)[2]\2\d{3}\2\d{4}\b");
            //Regex regex = new Regex(@"(?<=^|\s)\+359( |-)2\1\d{3}\1\d{4}(?=\s|$)");

            string phoneNumber = Console.ReadLine();

            MatchCollection validNumbers = regex.Matches(phoneNumber);

            Console.WriteLine(string.Join(", ", validNumbers));
        }
    }
}
