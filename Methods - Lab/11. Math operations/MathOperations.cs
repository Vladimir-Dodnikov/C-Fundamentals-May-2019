using System;

namespace _11._Math_operations
{
    class MathOperations
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char strOperator = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Calculate(firstNumber, strOperator, secondNumber)}");
        }
		static double Calculate(int firstNumber, char strOperator, int secondNumber)
        {
            double result = 0;
            switch (strOperator)
            {
                case '*': result = (firstNumber * secondNumber);
                    break;
                case '/':  result = (firstNumber / (double)secondNumber);
                    break;
                case '+':  result = (firstNumber + secondNumber);
                    break;
                case '-':  result = (firstNumber - secondNumber);
                    break;
            }
            return result;
        }
    }
}
