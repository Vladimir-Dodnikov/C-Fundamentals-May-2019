using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class RandomizeWords
    {
        static void Main()
        {
            ////variant 1
            //string[] words = Console.ReadLine().Split(' ');
            //Random rnd = new Random();
            //for (int pos1 = 0; pos1 < words.Length; pos1++)
            //{
            //    int pos2 = rnd.Next(words.Length);
            //    // TODO: Swap words[pos1] with words[pos2]
            //    var randomEL = words[pos2];
            //    var currentEL = words[pos1];
            //    words[pos1] = randomEL;
            //    words[pos2] = currentEL;
            //}
            //Console.WriteLine(string.Join(Environment.NewLine, words));

            var random = new Random();

            var words = Console.ReadLine()
                 .Split()
                 .ToList();

            for (int i = 0; i < words.Count; i++)
            {
                var randomIndex = random.Next(0, words.Count);

                var randomElement = words[randomIndex];
                var element = words[i];

                words[randomIndex] = element;
                words[i] = randomElement;
            }
            //Console.WriteLine(string.Join(Environment.NewLine, words));
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
