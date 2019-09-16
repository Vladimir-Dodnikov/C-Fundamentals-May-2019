using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    class ListOfStudents
    {
        public List<Student> Student { get; set; }
    }
    class Student
    {
        public Student(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
    }
    class Students
    {
        static void Main()
        {
            var listOfStudents = new ListOfStudents();
            listOfStudents.Student = new List<Student>();

            int countOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfStudents; i++)
            {
                var input = Console.ReadLine().Split();
                var currentStudent = new Student(input[0], input[1], double.Parse(input[2]));
                listOfStudents.Student.Add(currentStudent);
            }
            
            var sortedList = listOfStudents.Student.OrderByDescending(o => o.Grade).ToList();
            foreach (var student in sortedList)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }
        }
    }
}
