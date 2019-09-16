using System;
using System.Linq;

namespace _03._Zig_ZagArrays
{
    class ZigZagArrays
    {
        static void Main()
        {
            int arrElements = int.Parse(Console.ReadLine());

            int[] firstArr = new int[arrElements];

            int[] secondArr = new int[arrElements];

            for (int i = 0; i < arrElements; i++)
            {
                int[] current = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = current[0];
                    secondArr[i] = current[1];
                }
                else
                {

                    firstArr[i] = current[1];
                    secondArr[i] = current[0];
                }
            }
            Console.Write(string.Join(" ", firstArr));
            Console.WriteLine();
            Console.Write(string.Join(" ", secondArr));
        }
    }
}
