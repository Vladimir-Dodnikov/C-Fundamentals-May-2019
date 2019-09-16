using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] inputWords = Console.ReadLine().Split();

            var oddOccurrences = new Dictionary<string, int>();

            foreach (var item in inputWords)
            {
                string word = item.ToLower();
                if (!oddOccurrences.ContainsKey(word))
                {
                    oddOccurrences[word] = 0;
                }
                oddOccurrences[word]++;
            }
            var sortedOccurences = oddOccurrences.Where(x => x.Value % 2 == 1);

            foreach (var item in sortedOccurences)
            {
                Console.Write(item.Key + " ");
            }
        }
    }
}
