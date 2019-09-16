using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._Emoji_Sumator
{
    class EmojiSumator
    {
        static void Main()
        {
            string text = Console.ReadLine();

            List<int> emojiCode = Console.ReadLine()
                .Split(':')
                .Select(int.Parse)
                .ToList();
            //hints - has to check if it contains any emoji at all - (?<=) & (?=) !!!!
            Regex myRegEx = new Regex(@"(?<=[\s])(?<emoji>:[a-z]{4,}:)(?=[\s,.!?])"); // don't have emji (@" (:[a-z]{4,}:)[,.?! ]")

            List<string> listOfEmojis = new List<string>();

            int totalEmojiPoints = 0;

            bool isMatch = myRegEx.IsMatch(text);

            //StringBuilder newStrBuild = new StringBuilder();

            //for (int i = 0; i < emojiCode.Count; i++)
            //{
            //    newStrBuild.Append((char)emojiCode[i]);
            //}

            if (isMatch)
            {
                MatchCollection matches = myRegEx.Matches(text);

                foreach (Match emojis in matches)
                {
                    listOfEmojis.Add(emojis.Groups[1].Value);
                }

                for (int i = 0; i < listOfEmojis.Count; i++)
                {
                    string theEmoji = listOfEmojis[i];

                    for (int k = 1; k < theEmoji.Length - 1; k++) // this for start from 1 end length - 1
                    {
                        if (char.IsLetter(theEmoji[k]))
                        {
                            totalEmojiPoints += (int)theEmoji[k];
                        }
                    }

                }
            }
            string givenEmoji = string.Empty;

            for (int i = 0; i < emojiCode.Count; i++) // this is second check, where you collect the current ones
            {
                char symbol = (char)emojiCode[i];       // Check if any of the valid emoji names
                                                       //is equal to the name received form the emoji code and if it is –
                                                       //multiply the total emoji power by 2. (This is catch)
                givenEmoji += symbol;
            }

            for (int i = 0; i < listOfEmojis.Count; i++)
            {
                //remove ':' from the string !!!!
                string currentEmoji = listOfEmojis[i].Remove(0, 1);
                currentEmoji = currentEmoji.Remove(currentEmoji.Length - 1, 1);

                //compare to equals                    //also can compare with the stringbuilder!!
                if (givenEmoji == currentEmoji)
                {
                    totalEmojiPoints *= 2;
                    break;
                }
            }
            // if-check for any left valid emojis   !!!
            if (listOfEmojis.Count > 0)
            {
                Console.WriteLine("Emojis found: " + string.Join(", ", listOfEmojis));
            }

            Console.WriteLine($"Total Emoji Power: {totalEmojiPoints}");
        }
    }
}
