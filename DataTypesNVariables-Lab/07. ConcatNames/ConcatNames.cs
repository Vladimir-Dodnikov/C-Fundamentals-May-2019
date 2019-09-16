using System;

namespace _07._ConcatNames
{
    class ConcatNames
    {
        static void Main()
        {
            string typeOne = Console.ReadLine();
            string typeTwo = Console.ReadLine();
            string typeThree = Console.ReadLine();
           
            Console.WriteLine($"{typeOne}{typeThree}{typeTwo}");
            //Console.WriteLine(typeOne + typeThree + typeTwo);
        }
    }
}
