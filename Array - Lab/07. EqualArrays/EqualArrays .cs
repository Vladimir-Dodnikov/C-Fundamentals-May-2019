using System;
using System.Linq;

namespace _07._EqualArrays
{
    class EqualArrays
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum1 += firstArray[i];
                    sum2 += secondArray[i];
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            }
        }
    }
}
