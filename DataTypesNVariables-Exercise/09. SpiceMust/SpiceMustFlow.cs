using System;

namespace _09._SpiceMust
{
    class SpiceMustFlow
    {
        static void Main()
        {
            long startingYield = int.Parse(Console.ReadLine());
            long totalSpice = 0;
            long daysCount = 0;

            if (startingYield >= 100)
            {
                do
                {
                    daysCount++;
                    totalSpice = (totalSpice + startingYield) - 26;
                    startingYield -= 10;
                } while (startingYield >= 100);
                {
                    totalSpice -= 26;
                }
                Console.WriteLine(daysCount);
                Console.WriteLine(totalSpice);
            }
            else
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(totalSpice);
            }
        }
    }
}
