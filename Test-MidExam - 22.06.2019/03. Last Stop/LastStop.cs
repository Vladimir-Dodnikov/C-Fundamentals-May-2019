using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Last_Stop
{
    class LastStop
    {
        static void Main()
        {
            List<int> paintingNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = string.Empty;

            while ((input=Console.ReadLine()) != "END")
            {
                string[] commandArgs = input.Split().ToArray();
                string command = commandArgs[0];

                if (command == "Change")
                {
                    int paintNumber = int.Parse(commandArgs[1]);
                    int replacingPaintNumber = int.Parse(commandArgs[2]);

                    if (paintingNumbers.Contains(paintNumber))
                    {
                        int paintNumberIndex = paintingNumbers.IndexOf(paintNumber);
                        paintingNumbers.RemoveAt(paintNumberIndex);
                        paintingNumbers.Insert(paintNumberIndex, replacingPaintNumber);
                    }
                }
                else if (command == "Hide")
                {
                    int paintNumber = int.Parse(commandArgs[1]);
                    for (int i = 0; i < paintingNumbers.Count; i++)
                    {
                        if (paintingNumbers.Contains(paintNumber))
                        {
                            paintingNumbers.Remove(paintNumber);
                        }
                    }
                }
                else if (command == "Switch")
                {
                    int paintNumberOne = int.Parse(commandArgs[1]);
                    int paintNumberTwo = int.Parse(commandArgs[2]);
                    
                        if (paintingNumbers.Contains(paintNumberOne) && paintingNumbers.Contains(paintNumberTwo))
                        {
                            int firstNumberIndex = paintingNumbers.IndexOf(paintNumberOne);
                            int secondNumberIndex = paintingNumbers.IndexOf(paintNumberTwo);

                            paintingNumbers[firstNumberIndex] = paintNumberTwo;
                            paintingNumbers[secondNumberIndex] = paintNumberOne;
                        }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    
                    int paintNumber = int.Parse(commandArgs[2]);

                    if (index >= 0 && index <= paintingNumbers.Count - 1)
                    {
                        paintingNumbers.Insert(index+1, paintNumber);
                    }
                }
                else if (command == "Reverse")
                {
                    paintingNumbers.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", paintingNumbers));
        }
    }
}
