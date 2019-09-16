using System;

namespace _04._Text_Filter
{
    class TextFilter
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ");

            string text = Console.ReadLine();

            char replacement = '*';

            foreach (var banWord in bannedWords)
            {
                text = text.Replace(banWord, new string(replacement, banWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
