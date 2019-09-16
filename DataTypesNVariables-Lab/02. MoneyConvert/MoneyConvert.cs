using System;

namespace _02._MoneyConvert
{
    class MoneyConvert
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            double convertToDollars = input * 1.31;
            Console.WriteLine($"{convertToDollars:f3}");
        }
    }
}
