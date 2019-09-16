using System;

namespace _02._Vowels_Count
{
    class VowelsCount
    {
        static void Main()
        {
            string entry = Console.ReadLine().ToLower();

            GetCountOfVowels(entry);
        }

        static void GetCountOfVowels(string entry)
        {
            int countVowels = 0;
            string vowels = "aeoui";
            for (int i = 0; i < entry.Length; i++)
            {
                char currentChar = entry[i];
                if (vowels.Contains(currentChar.ToString()))
                {
                    countVowels++;
                }
            }
            Console.WriteLine(countVowels);
        }
    }
}
