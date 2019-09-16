using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main()
        {
            var word = Console.ReadLine().Split();

            var countChars = new Dictionary<char, int>();

            foreach (var item in word)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    char c = item[i];
                    if (!countChars.ContainsKey(c))
                    {
                        countChars[c] = 0;
                    }
                    countChars[c]++;
                }
            }
            foreach (var item in countChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
