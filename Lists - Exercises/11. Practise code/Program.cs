using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Add(List<string> schedule, string[] command)
        {
            string lessonTitle = command[1];
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Add(lessonTitle);
            }
        }

        static void Insert(List<string> schedule, string[] command)
        {
            string lessonTitle = command[1];
            int index = int.Parse(command[2]);

            if (!schedule.Contains(lessonTitle) && index >= 0 && index < schedule.Count)
            {
                schedule.Insert(index, lessonTitle);
            }
            else if (!schedule.Contains(lessonTitle) && index >= schedule.Count)
            {
                schedule.Add(lessonTitle);
            }
        }

        static void Remove(List<string> schedule, string[] command)
        {
            string lessonTitle = command[1];
            if (schedule.Contains(lessonTitle))
            {
                schedule.Remove(lessonTitle);
            }
            else if (schedule.Contains($"{lessonTitle}-Exercise"))
            {
                schedule.Remove($"{lessonTitle}-Exercise");
            }
        }

        static void Swap(List<string> schedule, string[] command)
        {
            string lessonOneTitle = command[1];
            string lessonTwoTitle = command[2];
            if (schedule.Contains(lessonOneTitle) && schedule.Contains(lessonTwoTitle))
            {
                int indexFirstLesson = schedule.IndexOf(lessonOneTitle);
                int indexSecondLesson = schedule.IndexOf(lessonTwoTitle);

                schedule[indexFirstLesson] = lessonTwoTitle;
                schedule[indexSecondLesson] = lessonOneTitle;

                string exerciseOne = string.Empty;
                string exerciseTwo = string.Empty;

                if (schedule.Contains($"{lessonOneTitle}-Exercise"))
                {
                    exerciseOne = $"{lessonOneTitle}-Exercise";
                    schedule.Remove(exerciseOne);
                }
                else if (schedule.Contains($"{lessonTwoTitle}-Exercise"))
                {
                    exerciseTwo = $"{lessonTwoTitle}-Exercise";
                    schedule.Remove(exerciseTwo);
                }

                if (exerciseOne != string.Empty)
                {
                    int lessonOneIndex = schedule.IndexOf(lessonOneTitle);
                    if (lessonOneIndex == schedule.Count - 1)
                    {
                        schedule.Add(exerciseOne);
                    }
                    else
                    {
                        schedule.Insert(lessonOneIndex + 1, exerciseOne);
                    }
                }

                else if (exerciseTwo != string.Empty)
                {
                    int lessonTwoIndex = schedule.IndexOf(lessonTwoTitle);
                    if (lessonTwoIndex == schedule.Count - 1)
                    {
                        schedule.Add(exerciseTwo);
                    }
                    else
                    {
                        schedule.Insert(lessonTwoIndex + 1, exerciseTwo);
                    }
                }
            }
        }

        static void Exercise(List<string> schedule, string[] command)
        {
            string lessonTitle = command[1];
            if (schedule.Contains(lessonTitle) && !schedule.Contains($"{lessonTitle}-Exercise"))
            {
                int lessonIndex = schedule.IndexOf(lessonTitle);
                string item = $"{lessonTitle}-Exercise";
                if (lessonIndex == schedule.Count - 1)
                {
                    schedule.Add(item);
                }
                else
                {
                    schedule.Insert(lessonIndex + 1, item);
                }
            }
            else if (!schedule.Contains(lessonTitle))
            {
                schedule.Add(lessonTitle);
                schedule.Add($"{lessonTitle}-Exercise");
            }

        }

        static void Main()
        {

            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string[] command = Console.ReadLine().Split(":");

            while (!command.Contains("course start"))
            {
                if (command.Contains("Add"))
                {
                    Add(schedule, command);
                }
                else if (command.Contains("Insert"))
                {
                    Insert(schedule, command);
                }
                else if (command.Contains("Remove"))
                {
                    Remove(schedule, command);
                }
                else if (command.Contains("Swap"))
                {
                    Swap(schedule, command);
                }
                else if (command.Contains("Exercise"))
                {
                    Exercise(schedule, command);
                }

                command = Console.ReadLine().Split(":");
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}