using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Messaging
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<char> text = Console.ReadLine().ToList();
            List<char> takenChars = new List<char>();

            foreach (var item in numbers)
            {
                int searchedIndex = GetSum(item);

                if (searchedIndex > text.Count)
                {
                    searchedIndex -= text.Count;
                }
                char searchedChar = text[searchedIndex];

                takenChars.Add(searchedChar);
                text.Remove(searchedChar);
            }

            Console.WriteLine(string.Join("", takenChars));
            
        }
        static int GetSum (int item)
        {
            int sum = 0;
            while (item > 0)
            {
                sum += item % 10;
                item /= 10;
            }
            return sum;
        }
    }
}
