using System;

namespace _07._NxN_Matrix
{
    class NxNMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                GetMatrix(n);
            }
        }

        private static void GetMatrix(int n)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
