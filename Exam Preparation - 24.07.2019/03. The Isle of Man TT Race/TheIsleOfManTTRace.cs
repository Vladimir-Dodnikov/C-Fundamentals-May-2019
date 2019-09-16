using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._The_Isle_of_Man_TT_Race
{
    class TheIsleOfManTTRace
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                string lengthPattern = @"=(\d+)!!";

                Match m = Regex.Match(input, lengthPattern);

                if (m.Success)
                {
                    int length = int.Parse(m.Groups[1].Value);
                    string pattern = $@"([#$%*&])(?<name>\w+)\1=(\d+)!!(.{{{length}}})$";   //Образува още една група
                    //string pattern = $@"([#$%*&])(?<name>\w+)\1=(\d+)!!(.*)$";            //вариант 2 - без динамично подпъхване

                    Match match = Regex.Match(input, pattern);

                    if (match.Success)
                    {
                        string name = match.Groups["name"].Value;
                        //int length = int.Parse(match.Groups[2].Value);
                        string geohashcode = match.Groups[3].Value;                         //затова не е 4
                        //if (length == geohashcode.length) -> всичко по-надолу
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < geohashcode.Length; i++)
                        {
                            sb.Append((char)(geohashcode[i] + length));
                        }

                        Console.WriteLine($"Coordinates found! {name} -> {sb.ToString()}");
                        break;
                    }
                }

                Console.WriteLine($"Nothing found!");
            }
        }
    }
}
