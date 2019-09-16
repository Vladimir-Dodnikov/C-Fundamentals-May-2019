using System;

namespace _08._TownInfo
{
    class TownInfo
    {
        static void Main()
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double townArea = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {townArea} square km.");
        }
    }
}
