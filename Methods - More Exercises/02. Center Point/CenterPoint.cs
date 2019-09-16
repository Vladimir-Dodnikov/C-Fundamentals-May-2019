using System;

namespace _02._Center_Point
{
    class CenterPoint
    {
        static void Main()
        {
            double dotX1 = double.Parse(Console.ReadLine());
            double dotY1 = double.Parse(Console.ReadLine());
            double dotX2 = double.Parse(Console.ReadLine());
            double dotY2 = double.Parse(Console.ReadLine());

            double dist1 = CalcDistance(dotX1, dotY1);
            double dist2 = CalcDistance(dotX2, dotY2);

            double[] array = new double[2];

            if (dist1 >= dist2)
            {
                array[0] = dotX2;
                array[1] = dotY2;
            }
            else
            {
                array[0] = dotX1;
                array[1] = dotY1;
            }

            Console.WriteLine($"({array[0]}, {array[1]})");
        }

        private static double CalcDistance(double dotX, double dotY)
        {
            double distance = Math.Sqrt(Math.Pow(dotX, 2) + Math.Pow(dotY, 2));
            return distance;
        }
    }
}
