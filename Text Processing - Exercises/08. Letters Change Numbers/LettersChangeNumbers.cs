using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _08._Letters_Change_Numbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            double sum = 0;
            
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Length >= 3 && char.IsLetter(input[i][0]) && char.IsLetter(input[i][input[i].Length-1]))
                {
                    string word = input[i];
                    char firstLetter = word[0];
                    char secondLetter = word[word.Length - 1];

                    double number = double.Parse(word.Substring(1, word.Length - 2));

                    double result = 0;
                    if (char.IsUpper(firstLetter))
                    {
                        result = number / (firstLetter - 'A' + 1);
                    }
                    else
                    {
                        result = number * (firstLetter - 'a' + 1);
                    }

                    if (char.IsUpper(secondLetter))
                    {
                        result -= (secondLetter - 'A' + 1);
                    }
                    else
                    {
                        result += (secondLetter - 'a' + 1);
                    }
                    sum += result;
                }
            }

            Console.WriteLine($"{sum:f2}");

        }
    }
}
