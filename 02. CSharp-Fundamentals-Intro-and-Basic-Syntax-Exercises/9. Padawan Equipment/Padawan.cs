using System;

namespace _9._Padawan_Equipment
{
    class Padawan
    {
        static void Main(string[] args)
        {
            double ownedMoney = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double singleSabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double sabreSum = Math.Ceiling(studentCount * 1.10) * singleSabrePrice;
            double robeSum = studentCount * robePrice;
            double beltSum = (studentCount-studentCount/6) * beltPrice;
            
            double sum = sabreSum + robeSum + beltSum;
            double result = ownedMoney - sum;

            if (result >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(result):f2}lv more.");
            }
        }
    }
}
