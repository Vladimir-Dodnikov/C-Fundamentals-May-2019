using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "end")
                {
                    break;
                }
                //divide command
                string[] commandArgs = input.Split(" ");
                //get what command
                string command = commandArgs[0];
                //first command
                if (command == "exchange")
                {
                    //which index
                    int index = int.Parse(commandArgs[1]);
                    //if Invalid index
                    if (index < 0 || index > array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        //to continue read "input"
                        continue;
                    }
                    //get the result for exchange command
                    GetExchangeIndex(index, array);

                    Console.WriteLine(string.Join(", ", array));
                }
                else if (command == "max")
                {
                    //what type odd or even?
                    string typeNumber = commandArgs[1];
                    int resultFromModuleDivision = GetResultFromModuleDvision(typeNumber);
                    int maxNumberIndex = GetMaxEvenOrOddNumber(array, resultFromModuleDivision);
                    Console.WriteLine(maxNumberIndex);
                }
                else if (command == "min")
                {
                    //what type odd or even?
                    string typeNumber = commandArgs[1];
                    int resultFromModuleDivision = GetResultFromModuleDvision(typeNumber);
                    int minNumberIndex = GetMinEvenOrOddNumber(array, resultFromModuleDivision);
                    Console.WriteLine(minNumberIndex);
                }
            }
        }
        private static int GetMinEvenOrOddNumber(int[] array, int resultFromModuleDivision)
        {
            int minNumber = int.MaxValue;
            int minNumberIndex = -1;
            
            // check the whole array for even and odd
            for (int i = 0; i < array.Length; i++)
            {
                //create current copied number from array
                int currentNumber = array[i];
                if (currentNumber % 2 == resultFromModuleDivision &&
                    minNumber > currentNumber)
                {
                    minNumber = currentNumber;
                    //rewrite the idex of the odd/even number
                    minNumberIndex = i;
                }
            }
            return minNumberIndex;
        }
        private static int GetResultFromModuleDvision(string typeNumber)
        {
            int resultFromModuleDivision = -1;
            //check if number is odd or even
            if (typeNumber == "odd")
            {
                resultFromModuleDivision = 1;
            }
            else
            {
                resultFromModuleDivision = 0;
            }
            return resultFromModuleDivision;
        }

        private static int GetMaxEvenOrOddNumber(int[] array, int resultFromModuleDivision)
        {
            int maxNumber = int.MinValue;
            int maxNumberIndex = -1;
            // check the whole array for even and odd
            for (int i = 0; i < array.Length; i++)
            {
                //create current copied number from array
                int currentNumber = array[i];
                if (currentNumber % 2 == resultFromModuleDivision &&
                    maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                    //rewrite the idex of the odd/even number
                    maxNumberIndex = i;
                }
            }
            return maxNumberIndex;
        }

        private static void GetExchangeIndex(int index, int[] array)
        {
            //creat an array to save the left side of No1 array
            int[] tempArray = new int[index + 1];
            //a command that copy/paste from one array to another which and how much elements you wish
            // in this case from '0' to 'index+1'
            Array.Copy(array, tempArray, index + 1);
            //copy/paste the right side of No1 array - from 'index+1' to end
            int currentIndex = 0;
            for (int i = index + 1; i < array.Length; i++)
            {
                //copy/paste the elements
                array[currentIndex] = array[i];
                currentIndex++;
            }
            // paste the ledt side to the empty right side elements
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[currentIndex] = tempArray[i];
                currentIndex++;
            }
        }
    }
}
