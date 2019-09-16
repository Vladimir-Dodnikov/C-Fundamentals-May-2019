using System;

namespace _01._BlackFlag
{
    class BlackFlag
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            int expectedPlunder = int.Parse(Console.ReadLine());

            double gatheredPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                gatheredPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    gatheredPlunder += dailyPlunder * 0.5;
                }

                if (i % 5 == 0)
                {
                    gatheredPlunder -= gatheredPlunder * 0.3;
                }
            }

            if (gatheredPlunder >= (double)expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {gatheredPlunder:f2} plunder gained.");
            }
            else
            {
                double percent = (gatheredPlunder/expectedPlunder)*100;
                Console.WriteLine($"Collected only {percent:F2}% of the plunder.");
            }
        }
    }
}
