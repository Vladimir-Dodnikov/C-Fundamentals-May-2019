using System;

namespace _10._Rage_Expenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double displayCount = 0;

            double headsetSum = 0;
            double mouseSum = 0;
            double keyboardSum = 0;
            double displaySum = 0;

            double totalExpenses = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetSum++;
                }
                if (i % 3 == 0)
                {
                    mouseSum++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardSum++;
                    if (keyboardSum % 2 == 0)
                    {
                        displayCount = 1;
                    }
                }
                if (keyboardSum % 2 == 0 && displayCount == 1)
                {
                    displaySum++;
                    displayCount = 0;
                }
            }
            totalExpenses = (headsetSum * headsetPrice) +
                            (mouseSum * mousePrice) +
                            (keyboardSum * keyboardPrice) +
                            (displaySum * displayPrice);

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
