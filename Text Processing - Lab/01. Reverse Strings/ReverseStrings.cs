using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Reverse_Strings
{
    class ReverseStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "end")
                {
                    break;
                }
                string reversed = "";

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }

                Console.WriteLine($"{input} = {reversed}");

                input = Console.ReadLine();
            }
        }
    }
}
