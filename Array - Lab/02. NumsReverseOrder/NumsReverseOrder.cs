using System;

namespace _02._NumsReverseOrder
{
    class NumsReverseOrder
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            
        }
    }
}
