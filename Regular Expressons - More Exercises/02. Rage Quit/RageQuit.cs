﻿using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Rage_Quit
{
    class RageQuit
    {
        static void Main()
        {
            string input = Console.ReadLine();

            // We know that we want all words that end with a digit - 
            //e.g. asd5, @6, golf4, so this patters says "anything but a digit one or more times
            //([\D]) and one or more digits after that([0-9 ]+)".
            string delimitingPattern = @"[\D]+[0-9]+";

            // Next we want to get the count of the repetitions of a word - 
            //e.g. asd4 - we should repeat "asd" 4 times. This pattern will give us any digit one or more times.
            string numPattern = @"[\d]+";

            // The last part will be the message itself. It can contains everything but a digit.
            string messagePattern = @"[\D]+";

            // We create a match collection that will hold all words with their counts - e.g. "asd3", "golf4", "%@7".
            MatchCollection messageWithRepCount = Regex.Matches(input, delimitingPattern);

            // We create a StringBuilder that will hold our result that will be printed.
            StringBuilder outputMessage = new StringBuilder();

            foreach (Match message in messageWithRepCount)
            {
                // We use the number pattern to get the repetitions from each entry 
                //in our match collection that holds all words - 
                //e.g. asd5 - we get 5, golf4 - we get 4.
                Match repetition = Regex.Match(message.ToString(), numPattern);

                // Converting the number to int (it was of type Match).
                int repetitions = int.Parse(repetition.ToString());

                // We have the repetitions and now we take the text that we should repeat - 
                //e.g. asd5 - we take "asd", golf4 - "golf".
                Match messageText = Regex.Match(message.ToString(), messagePattern);

                // Converting the message to string (it was of type Match).
                string dummyMessage = messageText.ToString();

                // Adding our message to our StringBuilder with the repetitions number that we already have - 
                //e.g. if we have "asd3" we will have in our StringBuilder "asdasdasd".
                for (int i = 0; i < repetitions; i++)
                {
                    outputMessage.Append(dummyMessage);
                }
            }
            // Converting the output to string (it was StringBuilder) and to capital letters.
            string output = outputMessage.ToString().ToUpper();

            // Getting the number of unique symbols.
            int uniqueSymbolsCount = output.Distinct().Count(); 

            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(output);
        }
    }
}
