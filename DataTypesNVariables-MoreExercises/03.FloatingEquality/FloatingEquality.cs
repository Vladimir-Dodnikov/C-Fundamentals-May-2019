using System;

namespace _03.FloatingEquality
{
    class FloatingEquality
    {
        static void Main()
        {
            double firtNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double precisionEPS = 0.000001;
            double result = Math.Abs(firtNumber - secondNumber);
            if (result >= precisionEPS)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
