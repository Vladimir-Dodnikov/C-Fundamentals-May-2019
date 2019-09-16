using System;

namespace _09._Greater_of_Two_Values
{
    class GreaterOfTwoValues
    {
        
        static void Main()
        {
            string typeOfValue = Console.ReadLine();

            if (typeOfValue == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNumber, secondNumber));
            }
            else if (typeOfValue == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar, secondChar));
            }
            else if (typeOfValue == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GetMax(firstString, secondString));
            }
        }
		
		static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
