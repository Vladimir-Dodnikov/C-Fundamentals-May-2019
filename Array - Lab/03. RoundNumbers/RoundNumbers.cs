using System;

namespace _03._RoundNumbers
{
    class RoundNumbers
    {
        static void Main()
        {
            string numbersAsText = Console.ReadLine();

            string[] array = numbersAsText.Split();

            for (int i = 0; i < array.Length; i++)
            {
                double number = double.Parse(array[i]);
                double roundedNumber = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundedNumber}");
            }
            
        }
    }
}
