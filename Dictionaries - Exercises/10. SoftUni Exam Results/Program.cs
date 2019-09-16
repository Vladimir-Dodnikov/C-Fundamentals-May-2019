using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main()
        {
            var languageAndSubmissions = new Dictionary<string, int>();
            var userAndPoints = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] inputArgs = input.Split("-").ToArray();
                string userName = inputArgs[0];

                if (inputArgs[1] != "banned")
                {
                    string language = inputArgs[1];
                    int points = int.Parse(inputArgs[2]);

                    if (!userAndPoints.ContainsKey(userName))
                    {
                        userAndPoints.Add(userName, 0);
                    }
                    // сравнява точки на един и същи човек и записване на по-големия му резултат
                    if (points > userAndPoints[userName])   //userAndPoints[userName] == x.Value
                    {
                        userAndPoints[userName] = points;
                    }

                    if (languageAndSubmissions.ContainsKey(language))
                    {
                        languageAndSubmissions[language] += 1;
                    }
                    else
                    {
                        languageAndSubmissions[language] = 1;
                    }
                }
                else
                {
                    if (userAndPoints.ContainsKey(userName))
                    {
                        userAndPoints.Remove(userName);
                    }
                }

                input = Console.ReadLine();
            }

            var sortedResults = userAndPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (var student in sortedResults)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            var sortedSubmissions = languageAndSubmissions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");
            foreach (var student in sortedSubmissions)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
        }
    }
}
