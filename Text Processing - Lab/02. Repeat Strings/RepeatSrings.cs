using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class RepeatSrings
    {
        static void Main()
        {
            string[] inputArr = Console.ReadLine().Split();

            foreach (var word in inputArr)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write( word);
                }
            }

            //StringBuilder words = new StringBuilder();
            //foreach (var word in inputArr)
            //{
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        words.Append(word);
            //    }
            //}
            //Console.WriteLine(string.Join("", words));
        }
    }
}
