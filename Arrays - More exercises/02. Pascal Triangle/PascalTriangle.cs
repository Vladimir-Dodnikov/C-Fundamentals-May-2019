using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class PascalTriangle
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[n][];

            for (long i = 0; i < n; i++)
            {
                jaggedArray[i] = new long[i + 1];

                for (long t = 0; t < i + 1; t++)
                {
                    if (t > 0 && t < jaggedArray[i].Length - 1)
                    {
                        jaggedArray[i][t] = jaggedArray[i - 1][t - 1] + jaggedArray[i - 1][t];
                    }
                    else
                    {
                        jaggedArray[i][t] = 1;
                    }
                }
            }

            foreach (long[] item in jaggedArray)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
