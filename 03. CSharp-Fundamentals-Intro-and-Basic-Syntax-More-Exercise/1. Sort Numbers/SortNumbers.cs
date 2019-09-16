using System;

namespace Sort_Numbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("{0}", a);
                    Console.WriteLine("{0}", b);
                    Console.WriteLine("{0}", c);
                }
                else
                {
                    Console.WriteLine("{0}", a);
                    Console.WriteLine("{0}", c);
                    Console.WriteLine("{0}", b);
                }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine("{0}", b);
                    Console.WriteLine("{0}", a);
                    Console.WriteLine("{0}", c);
                }
                else
                {
                    Console.WriteLine("{0}", b);
                    Console.WriteLine("{0}", c);
                    Console.WriteLine("{0}", a);
                }
            }
            else if ((c > a) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine("{0}", c);
                    Console.WriteLine("{0}", a);
                    Console.WriteLine("{0}", b);
                }
                else
                {
                    Console.WriteLine("{0}", c);
                    Console.WriteLine("{0}", b);
                    Console.WriteLine("{0}", a);
                }
            }
        }
    }
}
