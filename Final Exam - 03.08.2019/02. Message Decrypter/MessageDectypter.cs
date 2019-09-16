using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Message_Decrypter
{
    class MessageDectypter
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"^([$|%])([A-Z][a-z]{3,})\1: \[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";

                Match valid = Regex.Match(input, pattern);
                StringBuilder sb = new StringBuilder();

                if (valid.Success)
                {
                    string tag = valid.Groups[2].Value;
                    int one = int.Parse(valid.Groups[3].Value);
                    int two = int.Parse(valid.Groups[4].Value);
                    int three = int.Parse(valid.Groups[5].Value);

                    char first = (char)(one);
                    sb.Append(first);
                    char second = (char)(two);
                    sb.Append(second);
                    char third = (char)(three);
                    sb.Append(third);

                    Console.WriteLine($"{tag}: {sb.ToString()}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
