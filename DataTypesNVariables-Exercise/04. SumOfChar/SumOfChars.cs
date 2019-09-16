using System;

namespace _04._SumOfChar
{
    class SumOfChars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char current = char.Parse(Console.ReadLine());
                sum += current;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
