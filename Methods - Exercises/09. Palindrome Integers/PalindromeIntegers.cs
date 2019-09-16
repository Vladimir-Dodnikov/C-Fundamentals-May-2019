using System;

namespace _09._Palindrome_Integers
{
    class PalindromeIntegers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (GetPalidromeNumber(input) == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }

        private static bool GetPalidromeNumber(string input)
        {
            char firstChar = input[0];
            char lastChar = input[input.Length - 1];

            if (firstChar == lastChar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
