using System;

namespace _10._Top_Number
{
    class TopNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            GetTopNumber(number);
        }

        private static void GetTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sumDigits = 0;
                bool oddDigit = false;
                int currentNumber = i;

                while (true)
                {
                    if (currentNumber == 0)
                    {
                        break;
                    }
                    int nextNumber = currentNumber % 10;
                    sumDigits += nextNumber;
                    if (!(nextNumber % 2 == 0))
                    {
                        oddDigit = true;
                    }
                    currentNumber /= 10;
                }

                if (sumDigits % 8 == 0 && oddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
