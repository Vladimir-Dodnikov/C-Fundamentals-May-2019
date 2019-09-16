using System;

namespace _06._Calculate_Rectangle_Area
{
    class CalcRectangleArea
    {  
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = CalculateRectangleArea(width, height);
            Console.WriteLine(area);
        }
		static int CalculateRectangleArea(int width, int height)
        {
            return width * height;
        }
    }
}
