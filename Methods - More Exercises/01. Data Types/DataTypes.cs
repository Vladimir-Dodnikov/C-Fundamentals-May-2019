using System;

namespace _01._Data_Types
{
    class DataTypes
    {
        static void Main()
        {
            string dataType = Console.ReadLine();

            GetDataTypeCases(dataType);
        }

        private static void GetDataTypeCases(string dataType)
        {
            if (dataType == "int")
            {
                int number = int.Parse(Console.ReadLine());
                int result = GetDataType(number);
                Console.WriteLine(result);
            }
            else if (dataType == "real")
            {
                double number = double.Parse(Console.ReadLine());
                double result = GetDataType(number);
                Console.WriteLine($"{result:f2}");
            }
            else if (dataType == "string")
            {
                string input = Console.ReadLine();
                string result = GetDataType(input);
                Console.WriteLine(result);
            }
        }

        private static string GetDataType(string input)
        {
            string result = $"${input}$";
            return result;
        }

        private static double GetDataType(double number)
        {
            return number * 1.50;
        }

        private static int GetDataType(int number)
        {
            return number * 2;
        }
    }
}
