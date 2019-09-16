using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class ListsOfProducts
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();
                products.Add(current);
            }

            products.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
