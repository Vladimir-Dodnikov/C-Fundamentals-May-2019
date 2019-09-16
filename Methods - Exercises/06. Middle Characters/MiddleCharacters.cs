using System;

namespace _06._Middle_Characters
{
    class MiddleCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result = GetMiddleChar(input);
            Console.WriteLine(result);
        }

        private static string GetMiddleChar(string input)
        {
            string middle = string.Empty;
            int middleChar = input.Length / 2;
            if ((input.Length) % 2 != 0)
            {
                middle = input.Substring(middleChar, 1);
            }
            else
            {
                middle = input.Substring(middleChar - 1, 2);
            }
            return middle;
        }
    }
}
