using System;

namespace _05._Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (Test(num1, num2, num3) == 1)
            {
                Console.WriteLine("positive");
            }
            else if (Test(num1, num2, num3) == -1)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }

        public static double Test(double num1, double num2, double num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
                return 0;
            else if ((num1 > 0 && num2 > 0 && num3 > 0) || (num1 < 0 && num2 < 0 && num3 > 0) ||
                     (num1 < 0 && num2 > 0 && num3 < 0) || (num1 > 0 && num2 < 0 && num3 < 0))
                return 1;
            else
                return -1;
        }
    }
}
