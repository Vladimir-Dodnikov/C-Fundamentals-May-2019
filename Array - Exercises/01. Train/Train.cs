using System;
using System.Linq;

namespace _01._Train
{
    class Train
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sum = 0;
            for (int i = 0; i < train.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                
                sum += people;
                train[i] = people;
            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
