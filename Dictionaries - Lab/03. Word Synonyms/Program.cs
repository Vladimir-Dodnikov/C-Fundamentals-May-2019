using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            var wordSynonims = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!wordSynonims.ContainsKey(word))
                {
                    wordSynonims[word] = new List<string>();
                }
                wordSynonims[word].Add(synonim);
            }

            foreach (var item in wordSynonims)
            {
                var word = item.Key;
                var synonims = item.Value;

                Console.WriteLine($"{word} - {string.Join(", ", synonims)}");
            }
        }
    }
}
