using System;
using System.Linq;
using System.Text;

namespace _04.__Caesar_Cipher
{
    class CaesarCipher
    {
        static void Main()
        {
            //char[] text = Console.ReadLine()
            //    .ToCharArray()
            //    .Select(s => Convert.ToChar(s + 3))
            //    .ToArray();

            //Console.WriteLine(string.Join(string.Empty, text));

            StringBuilder result = new StringBuilder();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = (char)((int)text[i] + 3);
                result.Append(ch);
            }

            Console.WriteLine(result);
        }
    }
}
