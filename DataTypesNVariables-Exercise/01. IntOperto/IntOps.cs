using System;

namespace _01._IntOperto
{
    class IntOps
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourNumber = int.Parse(Console.ReadLine());

            int sum = ((firstNumber + secondNumber) / thirdNumber) * fourNumber;
            Console.WriteLine(sum);

        }
    }
}
