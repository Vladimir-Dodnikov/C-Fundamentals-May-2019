using System;

namespace _3._Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayWeek = Console.ReadLine();
            double price = 0;

            if (dayWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    price = groupCount * 8.45;
                    if (groupCount >= 30)
                    {
                        price = price - price * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    price = groupCount * 10.90;
                    if (groupCount >= 100)
                    {
                        price = price - 10 * 10.90;
                    }
                }
                else if (groupType == "Regular")
                {
                    price = groupCount * 15;
                    if (groupCount >= 10 && groupCount <= 20)
                    {
                        price = price - price * 0.05;
                    }
                }
            }
            else if (dayWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    price = groupCount * 9.80;
                    if (groupCount >= 30)
                    {
                        price = price - price * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    price = groupCount * 15.60;
                    if (groupCount >= 100)
                    {
                        price = price - 10 * 15.60;
                    }
                }
                else if (groupType == "Regular")
                {
                    price = groupCount * 20;
                    if (groupCount >= 10 && groupCount <= 20)
                    {
                        price = price - price * 0.05;
                    }
                }
            }
            else if (dayWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    price = groupCount * 10.46;
                    if (groupCount >= 30)
                    {
                        price = price - price * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    price = groupCount * 16;
                    if (groupCount >= 100)
                    {
                        price = price - 10 * 16;
                    }
                }
                else if (groupType == "Regular")
                {
                    price = groupCount * 22.50;
                    if (groupCount >= 10 && groupCount <= 20)
                    {
                        price = price - price * 0.05;
                    }
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
