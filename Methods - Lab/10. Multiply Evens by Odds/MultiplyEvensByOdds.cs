using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfOdd = GetSumOfOddDigits(number);
            int sumOfEven = GetSumOfEvenDigits(number);
            
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumOfOdd, sumOfEven));

        }
		
		static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            while (Math.Abs(number) >0)
            {
                int lastDigit = Math.Abs(number % 10);
                
                if ( lastDigit % 2 == 0)
                {
                    sumOdd += lastDigit;
                }
                number /= 10;
            }
            return sumOdd;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
            while (Math.Abs(number) > 0)
            {
                int lastDigit = Math.Abs(number % 10);
                
                if (lastDigit % 2 == 1)
                {
                    sumEven += lastDigit;
                }
                number /= 10;
            }
            return sumEven;
        }
        static int GetMultipleOfEvenAndOdds(int sumOdd, int sumEven)
        {
            return sumOdd * sumEven;
        }
    }
}
