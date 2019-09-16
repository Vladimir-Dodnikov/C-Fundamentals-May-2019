using System;

namespace _08._BeerKegs
{
    class BeerKegs
    {
        static void Main()
        {
            int countLines = int.Parse(Console.ReadLine());
            double biggerVolume = 0;
            string modelKeg = string.Empty;
            for (int i = 1; i <= countLines; i++)
            {
                string typeBeerKeg = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                int heigthKeg = int.Parse(Console.ReadLine());
                double volumeKeg = Math.PI * radiusKeg * radiusKeg * heigthKeg;

                if (volumeKeg > biggerVolume)
                {
                    biggerVolume = volumeKeg;
                    modelKeg = typeBeerKeg;
                }
            }
            Console.WriteLine(modelKeg);
        }
    }
}
