using System;

namespace _05._Add_and_Subtract
{
    class AddAndSubstract
    {
        static void Main()
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int result = GetSubstractOfTwo(firstInt, secondInt, thirdInt);
            Console.WriteLine(result);
        }
        static int GetSumOfFirstTwoIntegers(int first, int second)
        {
            return first + second;
        }
        static int GetSubstractOfTwo(int first, int second, int third)
        {
            return GetSumOfFirstTwoIntegers(first, second) - third;
        }
    }
}
