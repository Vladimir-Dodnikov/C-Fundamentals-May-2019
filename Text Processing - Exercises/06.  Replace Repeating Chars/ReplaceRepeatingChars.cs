using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.__Replace_Repeating_Chars
{
    class ReplaceRepeatingChars
    {
        static void Main()
        {
            string text = Console.ReadLine();

            List<char> result = new List<char>();
            result.Add(text[0]);

            for (int i = 0; i < text.Length; i++)
            {
                if (result.Last() != text[i])
                {
                    result.Add(text[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
