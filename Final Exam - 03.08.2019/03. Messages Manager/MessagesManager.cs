using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager
{
    class MessagesManager
    {
        static void Main()
        {
            Dictionary<string, int> usernameAndSent = new Dictionary<string, int>();
            Dictionary<string, int> usernameAndReceived = new Dictionary<string, int>();

            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] commandArgs = input.Split("=");
                string command = commandArgs[0];

                if (command == "Add")
                {
                    string user = commandArgs[1];
                    int sent = int.Parse(commandArgs[2]);
                    int received = int.Parse(commandArgs[3]);

                    if (!usernameAndSent.ContainsKey(user) && !usernameAndReceived.ContainsKey(user))
                    {
                        usernameAndSent[user] = sent;
                        usernameAndReceived[user] = received;
                    }
                }
                else if (command == "Message")
                {
                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    if (usernameAndSent.ContainsKey(sender) && usernameAndReceived.ContainsKey(receiver))
                    {
                       usernameAndSent[sender] = usernameAndSent[sender] += 1;

                        usernameAndReceived[receiver] = usernameAndReceived[receiver] += 1;

                        if ((usernameAndSent[sender] + usernameAndReceived[sender]) >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");

                            usernameAndSent.Remove(sender);
                            usernameAndReceived.Remove(sender);
                        }
                        if ((usernameAndReceived[receiver] + usernameAndSent[receiver]) >= capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");

                            usernameAndSent.Remove(receiver);
                            usernameAndReceived.Remove(receiver);
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string username = commandArgs[1];

                    if (username == "All")
                    {
                        usernameAndSent.Clear();
                        usernameAndReceived.Clear();
                    }
                    else
                    {
                        if (usernameAndSent.ContainsKey(username))
                        {
                            usernameAndSent.Remove(username);
                        }
                        if (usernameAndReceived.ContainsKey(username))
                        {
                            usernameAndReceived.Remove(username);
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {usernameAndSent.Keys.Count}");

            var sorted = usernameAndReceived
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var person in sorted)
            {
                int count = usernameAndSent[person.Key] + usernameAndReceived[person.Key];

                Console.WriteLine($"{person.Key} - {count}");
            }

        }
    }
}
