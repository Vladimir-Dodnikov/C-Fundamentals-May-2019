﻿using System;

namespace _7._Teathre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            if (age >=0 && age <=18)
            {
                if (day == "Weekday")
                {
                    price = 12;
                }
                else if (day =="Weekend")
                {
                    price = 15;
                }
                else if (day == "Holiday")
                {
                    price = 5;
                }
            }
            if (age > 18 && age <= 64)
            {
                if (day == "Weekday")
                {
                    price = 18;
                }
                else if (day == "Weekend")
                {
                    price = 20;
                }
                else if (day == "Holiday")
                {
                    price = 12;
                }
            }
            if (age > 64 && age <= 122)
            {
                if (day == "Weekday")
                {
                    price = 12;
                }
                else if (day == "Weekend")
                {
                    price = 15;
                }
                else if (day == "Holiday")
                {
                    price = 10;
                }
            }
            if (age <0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(price + "$");
            }
        }
    }
}
