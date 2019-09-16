using System;

namespace _03._Calculations
{
    class Calculations
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Console.WriteLine(CalculateWithAdd(firstNumber, secondNumber));
            }
            else if (command == "multiply")
            {
                CalculateWithMultiply(firstNumber, secondNumber);
            }
            else if (command == "subtract")
            {
                CalculateWithSubstract(firstNumber, secondNumber);
            }
            else if (command == "divide")
            {
                CalculateWithDivide(firstNumber, secondNumber);
            }
        }
		static int CalculateWithAdd(int firstNumber, int secondNumber)
        {
            int result = (firstNumber + secondNumber);
            return result;
        }
        static void CalculateWithMultiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
        static void CalculateWithSubstract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        static void CalculateWithDivide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
