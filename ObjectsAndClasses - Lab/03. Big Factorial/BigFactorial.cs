﻿using System;
using System.Numerics;

namespace _03._Big_Factorial
{
    class BigFactorial
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
