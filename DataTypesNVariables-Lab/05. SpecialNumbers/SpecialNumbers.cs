using System;

namespace _05._SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;

                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                var isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
