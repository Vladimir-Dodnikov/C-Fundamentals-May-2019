using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Party_Profit
{
    class PartyProfit
    {
        static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double sumParty = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                sumParty += 50;
                sumParty -= (partySize * 2);

                if (i % 3 == 0)
                {
                    sumParty -= (partySize * 3);
                }
                if (i % 5 == 0)
                {
                    sumParty += (partySize * 20);
                    if (i % 3 == 0)
                    {
                        sumParty -= (partySize * 2);
                    }
                }
            }

            double coinsPerCompanion = Math.Floor(sumParty / partySize);
            Console.WriteLine($"{partySize} companions received {coinsPerCompanion:f0} coins each.");
        }
    }
}
