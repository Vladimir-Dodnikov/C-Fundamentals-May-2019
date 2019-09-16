using System;

namespace _05._ACIIprint
{
    class PrintASCII
    {
        static void Main()
        {
            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());

            for (char i = (char)firstChar; i <= (char)secondChar; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
