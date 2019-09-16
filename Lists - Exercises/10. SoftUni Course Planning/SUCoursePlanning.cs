using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    class SUCoursePlanning
    {
        static void Main()
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] splittedInput = input.Split(":");
                string command = splittedInput[0];
                string lesson = splittedInput[1];

                if (command == "Add")
                {
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(splittedInput[2]);

                    if (!schedule.Contains(lesson))
                    {
                        schedule.Insert(index, lesson);
                    }
                }
                else if (command == "Remove")
                {
                    if (schedule.Contains(lesson))
                    {
                        schedule.Remove(lesson);
                    }
                }
                else if (command == "Swap")
                {
                    string secondLesson = splittedInput[2];
                    string exercise = "{0}-Exercise"; // {0} e shablon, moje da vkarvame kakvoto si iskame chrez .Format
                                                      // moje i kato placeHolder da se slaga sled ',' no kopirame koda!! i se dopuska greshka pri 100 povtoreniq
                    if (schedule.Contains(lesson) && schedule.Contains(secondLesson))
                    {
                        int firstLessonIndex = schedule.IndexOf(lesson);
                        int secondLessonIndex = schedule.IndexOf(secondLesson);

                        schedule[firstLessonIndex] = secondLesson;
                        schedule[secondLessonIndex] = lesson;

                        string firstLessonExercise = string.Format(exercise, lesson); //  {0} slaga lesson
                        string secondLessonExercise = string.Format(exercise, secondLesson); // {0} slaga secondLesson

                        if (schedule.Contains(firstLessonExercise))
                        {
                            int firstExerciseIndex = schedule.IndexOf(firstLessonExercise);

                            schedule.RemoveAt(firstExerciseIndex);
                            schedule.Insert(secondLessonIndex + 1, firstLessonExercise);

                        }
                        else if (schedule.Contains(secondLessonExercise))
                        {
                            int secondExerciseIndex = schedule.IndexOf(secondLessonExercise);

                            schedule.RemoveAt(secondExerciseIndex);
                            schedule.Insert(firstLessonIndex + 1, secondLessonExercise);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    string exercise = $"{lesson}-Exercise";
                    if (!schedule.Contains(exercise))
                    {
                        if (schedule.Contains(lesson))
                        {
                            int indexOfLesson = schedule.IndexOf(lesson);
                            schedule.Insert(indexOfLesson + 1, exercise);
                        }
                        else
                        {
                            schedule.Add(lesson);
                            schedule.Add(exercise);
                        }
                    }
                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
