using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main()
        {
            var registration = new Dictionary<string, string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] inputArgs = Console
                    .ReadLine()
                    .Split();
                string command = inputArgs[0];

                if (command == "register")
                {
                    string userName = inputArgs[1];
                    string licensePlateNumber = inputArgs[2];

                    if (!registration.ContainsKey(userName))
                    {
                        registration[userName] = licensePlateNumber;
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    string userName = inputArgs[1];
                    if (!registration.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else if (registration.ContainsKey(userName))
                    {
                        registration.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in registration)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
            //Console.WriteLine(Environment.NewLine, registration.Select(x=> $"{x.Key} => {x.Value}"));

            //string output = "{0} => {1}";                             izpolzva se pri nqkolko kolekcii s ednakuv format
            //Console.WriteLine(Environment.NewLine, registration
            //    .Select(x => string.Format(output, x.Key, x.Value)));
        }
    }
}
