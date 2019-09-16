using System;

namespace _08._Math_Power
{
    class MathPower
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(GetNumberPower(number, power));
        }
		
		 static int GetNumberPower(int number, int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
