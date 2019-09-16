using System;

namespace _07._Repeat_String
{
    class RepeatString
    {        
        static void Main()
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatedString(input, count));
        }
		
		static string RepeatedString(string input, int count)
        {
            string result = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
