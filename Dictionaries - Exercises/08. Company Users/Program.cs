using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main()
        {
            var companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] inputArr = Console.ReadLine()
                    .Split(" -> ");

                string company = inputArr[0];
                if (company == "End")
                {
                    break;
                }

                string employeeId = inputArr[1];
                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                if (!companies[company].Contains(employeeId))
                {
                    companies[company].Add(employeeId);
                }
            }
            foreach (var company in companies.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (var kvp in company.Value)
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
        }
    }
}
