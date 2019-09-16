using System;
using System.Collections.Generic;

namespace _01._String_Manipulator
{
    class StringManipulator
    {
        static void Main()
        {
            string result = string.Empty;

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input
                    .Split();
                string command = inputArgs[0];

                if (command == "Add")
                {
                    result += inputArgs[1];
                }
                else if (command == "Upgrade")
                {
                    var currentChar = inputArgs[1][0];              //[1] - string [1][0] - char na string
                    var nextSymbol = (char)(currentChar + 1);

                    result = result.Replace(currentChar, nextSymbol);   //replace all chars in the string with new one
                }
                else if (command == "Index")
                {
                    List<int> indexes = new List<int>();

                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == inputArgs[1][0])
                        {
                            indexes.Add(i);
                        }
                    }

                    if (indexes.Count == 0)
                    {
                        Console.WriteLine("None");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", indexes));
                    }
                }
                else if (command == "Remove")
                {
                    result = result.Replace(inputArgs[1], "");
                }
                else if (command == "Print")
                {
                    Console.WriteLine(result);
                }

                input = Console.ReadLine();
            }
        }
    }
}
