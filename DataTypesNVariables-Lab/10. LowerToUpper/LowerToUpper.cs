using System;

namespace _10._LowerToUpper
{
    class LowerToUpper
    {
        static void Main()
        {
            char type = char.Parse(Console.ReadLine());
            if (char.IsUpper(type))
            {
                Console.WriteLine("upper-case");
            }
            else if (char.IsLower(type))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
