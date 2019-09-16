using System;

namespace _04._Printing_Triangle
{
    class PrintTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                PrintFigure(row);
            }

            for (int row = n - 1; row >= 0; row--)
            {
                PrintFigure(row);
            }
        }
		 static void PrintFigure(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}
