using System;

namespace _07._WaterOver
{
    class WaterOverflow
    {
        static void Main()
        {
            int tankCapacity = 255;
            int count = int.Parse(Console.ReadLine());
            int sumCapacity = 0;

            for (int i = 1 ; i <= count; i++)
            {
                int currentCapacity = int.Parse(Console.ReadLine());
                
                if (sumCapacity + currentCapacity > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumCapacity += currentCapacity;
                }
            }
            Console.WriteLine(sumCapacity);
         }
    }
}
