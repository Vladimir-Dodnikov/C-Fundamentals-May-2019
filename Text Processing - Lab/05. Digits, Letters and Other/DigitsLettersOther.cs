using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class DigitsLettersOther
    {
        static void Main()
        {
            string line = Console.ReadLine();

            List<char> digits = new List<char>();
            List<char> chars = new List<char>();
            List<char> others = new List<char>();

            for (int i = 0; i < line.Length; i++)
            {
                char current = line[i];

                if (char.IsDigit(current))
                {
                    digits.Add(current);
                }
                else if (char.IsLetter(current))
                {
                    chars.Add(current);
                }
                else
                {
                    others.Add(current);
                }
            }
            Console.WriteLine(string.Join(string.Empty, digits));
            Console.WriteLine(string.Join(string.Empty, chars));
            Console.WriteLine(string.Join(string.Empty, others));
        }
    }
}
