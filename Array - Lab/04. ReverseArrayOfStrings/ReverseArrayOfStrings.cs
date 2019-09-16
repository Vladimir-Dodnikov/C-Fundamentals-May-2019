using System;
using System.Linq;

namespace _04._ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] stringChars = Console.ReadLine().Split(" ");
            //stringChars = stringChars.Reverse().ToArray(); po-lesen nachin

            for (int i = 0; i < stringChars.Length; i++) // tova e variant ot i=0 nagore/ drugototo e i=stringChars.length-1;
            {
                Console.Write(stringChars[stringChars.Length - i - 1] + " ");
            }
        }
    }
}
