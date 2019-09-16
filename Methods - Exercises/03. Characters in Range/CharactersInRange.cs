using System;

namespace _03._Characters_in_Range
{
    class CharactersInRange
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            GetAllCharsBetween(firstChar, secondChar);
        }

        private static void GetAllCharsBetween(char firstChar, char secondChar)
        {
            int first = Math.Min(firstChar, secondChar);
            int second = Math.Max(firstChar, secondChar);
            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
