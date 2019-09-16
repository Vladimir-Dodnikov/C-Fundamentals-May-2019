using System;
using System.Collections.Generic;

namespace _05._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
    class Startup
    {
        static void Main()
        {
            var student = new List<Student>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "end")
                {
                    break;
                }

                string[] studentInfo = input.Split(" ");
                string firstName = studentInfo[0];
                string LastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string hometown = studentInfo[3];

                if (IsStudentExisting(student, firstName, LastName))
                {
                    Student existingStudent = GetStudent(student, firstName, LastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = LastName;
                    existingStudent.Age = age;
                    existingStudent.Hometown = hometown;
                }
                else
                {
                    var studentData = new Student();
                    studentData.FirstName = firstName;
                    studentData.LastName = LastName;
                    studentData.Age = age;
                    studentData.Hometown = hometown;

                    student.Add(studentData);
                }
            }
            string nameOfCity = Console.ReadLine();
            foreach (Student item in student)
            {
                if (item.Hometown == nameOfCity)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }
        }

        static Student GetStudent(List<Student> student, string firstName, string lastName)
        {
            Student ExistingStudent = null;
            foreach (Student item in student)
            {
                if (item.FirstName == firstName && item.LastName == lastName)
                {
                    return ExistingStudent = item;
                }
            }
            return ExistingStudent;
        }

        static bool IsStudentExisting(List<Student> student, string firstName, string lastName)
        {
            foreach (Student item in student)
            {
                if (item.FirstName == firstName && item.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
