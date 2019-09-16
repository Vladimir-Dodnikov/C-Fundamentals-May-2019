using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main()
        {
            var courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] inputArr = Console.ReadLine().Split(" : ").ToArray();
                string courseName = inputArr[0];

                if (courseName == "end")
                {
                    break;
                }
                string studentName = inputArr[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studentName);
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var kvp in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
            // това е код на 1 ред, но е много грозно
            //Console.WriteLine(string.Join(Environment.NewLine, courses.OrderByDescending(x => x.Value.Count)
            //    .Select(kvp => $"{kvp.Key}: {kvp.Value.Count} {Environment.NewLine}" +
            //    $"{string.Join(Environment.NewLine, kvp.Value.OrderBy(x => x).Select(x => $"-- {x}"))}")));

        }
    }
}
