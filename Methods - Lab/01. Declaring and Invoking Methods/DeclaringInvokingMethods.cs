using System;

namespace _01._Declaring_and_Invoking_Methods
{
    class DeclaringInvokingMethods
    {
        static void Main()
        {
            SignNumber(int.Parse(Console.ReadLine()));
        }
        static void SignNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
