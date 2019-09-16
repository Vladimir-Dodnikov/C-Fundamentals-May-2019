using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class SmallestOfThreeNumbers
    {
        static void Main()
        {
            int result = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                result = SmallerNumber(number, result);
            }
            Console.WriteLine(result);
        }
        static int SmallerNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                return firstNumber;
            }

            return secondNumber;
        }
    }
}
