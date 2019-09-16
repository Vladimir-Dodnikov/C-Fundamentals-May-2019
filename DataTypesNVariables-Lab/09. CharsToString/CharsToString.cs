using System;

namespace _09._CharsToString
{
    class CharsToString
    {
        static void Main()
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            Console.WriteLine($"{one}{two}{three}");
        }
    }
}
