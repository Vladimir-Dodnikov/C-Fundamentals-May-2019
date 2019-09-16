using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class ExtractEmails
    {
        static void Main()
        {
            Regex emailValidation = new Regex(@"(\s[a-z]+[\w.-]+\w)@([a-z][-a-z]+?([.][a-z]+)+)\b");

            string input = Console.ReadLine();

            MatchCollection validEmails = emailValidation.Matches(input);

            foreach (Match email in validEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
