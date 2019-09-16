using System;

namespace _10._Pokemon
{
    class Pokemon
    {
        static void Main()
        {
            decimal pokePowerN = decimal.Parse(Console.ReadLine());
            decimal pokeTargetsM = decimal.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            decimal start = pokePowerN / 2;

            int countTargets = 0;

            while (true)
            {
                pokePowerN -= pokeTargetsM;
                countTargets++;
                if (exhaustionFactorY != 0)
                {
                    if (pokePowerN == start)
                    {
                        pokePowerN /= exhaustionFactorY;
                    }
                }
                if (pokePowerN < pokeTargetsM)
                {
                    break;
                }
            }
            Console.WriteLine(Math.Floor(pokePowerN));
            Console.WriteLine(countTargets);
        }
    }
}
