using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Snowballs
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            string bestResult = "";

            for (int i = 0; i < number; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (currentSnowballValue > snowballValue)
                {
                    snowballValue = currentSnowballValue;
                    string result = ($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
                    bestResult = result;
                }
            }
            Console.WriteLine(bestResult);
        }
    }
}
