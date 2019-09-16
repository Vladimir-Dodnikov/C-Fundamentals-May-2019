using System;

namespace _4._RevStri
{
    class RevString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            
        }
    }
}
