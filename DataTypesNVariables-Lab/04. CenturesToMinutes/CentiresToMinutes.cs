using System;

namespace _04._CenturesToMinutes
{
    class CenturesToMinutes
    {
        static void Main()
        {
            int centures = int.Parse(Console.ReadLine());
            double years = centures * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{centures} centuries = {years} years = {days:f0} days = {hours} hours = {minutes} minutes");
        }
    }
}
