using System;

namespace _01.__String_Manipulator
{
    class PrograStringManipulatorm
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string inputArgs = Console.ReadLine();

            while (inputArgs != "End")
            {
                string[] commandArgs = inputArgs.Split(" ");
                string command = commandArgs[0];

                if (command == "Translate")
                {
                    char character = char.Parse(commandArgs[1]);
                    char replacement = char.Parse(commandArgs[2]);

                    text = text.Replace(character, replacement);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string @string = commandArgs[1];

                    if (text.Contains(@string))
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
                else if (command == "Start")
                {
                    string @string = commandArgs[1];
                    string check = text.Substring(0, @string.Length);
                    if (check == @string)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
                else if (command == "Lowercase")
                {
                    string toLower = text.ToLower();
                    Console.WriteLine(toLower);
                }
                else if (command == "FindIndex")
                {
                    char charToFind = char.Parse(commandArgs[1]);
                    //
                    Console.WriteLine(text.LastIndexOf(charToFind));
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

                inputArgs = Console.ReadLine();
            }
        }
    }
}
