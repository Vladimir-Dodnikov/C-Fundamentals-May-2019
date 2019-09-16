using System;

namespace _08._Factorial_Division
{
    class FactorialDivision
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double result = (GetFirstFactorial(firstNumber) / (double)(GetSecondFactorial(secondNumber)));
            Console.WriteLine($"{result:f2}");
        }
        static double GetFirstFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
        static double GetSecondFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
