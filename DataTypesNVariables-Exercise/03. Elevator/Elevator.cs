using System;

namespace _03._Elevator
{
    class Elevator
    {
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            double courseCount = Math.Ceiling((double)peopleCount / elevatorCapacity);
            Console.WriteLine(courseCount);
        }
    }
}
