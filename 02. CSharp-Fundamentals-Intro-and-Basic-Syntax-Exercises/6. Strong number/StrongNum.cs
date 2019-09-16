using System;

namespace _6._Strong_number
{
    class StrongNum
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyNum = number;
            int sum = 0;
            while (copyNum != 0)
            {
                int currentDigit = copyNum % 10;
                int currentFactorial = 1;

                for (int i = 1; i <= currentDigit; i++)
                {
                    currentFactorial *= i;
                }
                sum += currentFactorial;
                copyNum /= 10;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
