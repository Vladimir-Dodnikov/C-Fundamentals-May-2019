using System;
using System.Linq;

namespace _02._Common_Elements
{
    class CommonElements
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split(" ");

            string[] secondArr = Console.ReadLine().Split(" ");

            for (int i = 0; i < secondArr.Length; i++)
            {
                string secondArrElement = secondArr[i];
                for (int k = 0; k < firstArr.Length; k++)
                {
                    string firstArrElement = firstArr[k];

                    if (firstArrElement == secondArrElement)
                    {
                        Console.Write(secondArrElement + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
