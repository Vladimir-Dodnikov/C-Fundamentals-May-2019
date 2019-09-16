using System;

namespace _03._Longer_Line
{
    class LongerLine
    {
        static void Main()
        {
            double dotX1 = double.Parse(Console.ReadLine());
            double dotY1 = double.Parse(Console.ReadLine());

            double dotX2 = double.Parse(Console.ReadLine());
            double dotY2 = double.Parse(Console.ReadLine());

            double dotX3 = double.Parse(Console.ReadLine());
            double dotY3 = double.Parse(Console.ReadLine());

            double dotX4 = double.Parse(Console.ReadLine());
            double dotY4 = double.Parse(Console.ReadLine());

            double line1 = CalcLength(dotX1, dotY1, dotX2, dotY2);
            double line2 = CalcLength(dotX3, dotY3, dotX4, dotY4);

            double dist1 = CalcDistance(dotX1, dotY1);
            double dist2 = CalcDistance(dotX2, dotY2);
            double dist3 = CalcDistance(dotX3, dotY3);
            double dist4 = CalcDistance(dotX4, dotY4);

            double[] array = new double[4];

            if (line1 <= line2)
            {
                array[0] = dotX3;
                array[1] = dotY3;
                array[2] = dotX4;
                array[3] = dotY4;

                if (dist4 < dist3)
                {
                    array[0] = dotX4;
                    array[1] = dotY4;
                    array[2] = dotX3;
                    array[3] = dotY3;
                }
            }
            else
            {
                array[0] = dotX1;
                array[1] = dotY1;
                array[2] = dotX2;
                array[3] = dotY2;

                if (dist2 < dist1)
                {
                    array[0] = dotX2;
                    array[1] = dotY2;
                    array[2] = dotX1;
                    array[3] = dotY1;
                }
            }
            Console.WriteLine($"({array[0]}, {array[1]})({array[2]}, {array[3]})");

        }

        private static double CalcDistance(double dotX, double dotY)
        {
            double distance = Math.Sqrt(Math.Pow(dotX, 2) + Math.Pow(dotY, 2));
            return distance;
        }

        private static double CalcLength(double dotX1, double dotY1, double dotX2, double dotY2)
        {
            double lineLength = Math.Sqrt(Math.Pow((dotX2-dotX1), 2) + Math.Pow((dotY2-dotY1), 2));
            return lineLength;
        }
    }
}
