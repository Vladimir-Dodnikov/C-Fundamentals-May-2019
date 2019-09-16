using System;

namespace _01._KmToMeters
{
    class KmToMeters
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double convertToKm = number / 1000.0;
            Console.WriteLine($"{convertToKm:f2}");
        }
    }
}
