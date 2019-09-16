using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.__Student_Academy
{
    class Program
    {
        static void Main()
        {
            var students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (count < n)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(grade);

                count++;
            }
            var sortedStudents = students.Where(x => x.Value.Average() >= 4.50)
                                         .OrderByDescending(x => x.Value.Average());
            
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents
                                    .Select(x => $"{x.Key} -> {x.Value.Average():f2}")));
        }
    }
}
