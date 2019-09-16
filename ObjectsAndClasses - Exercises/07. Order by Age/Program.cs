using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    class ListOfPeople
    {
        public List<People> ListOfPersons { get; set; }
    }
    class People
    {
        public People (string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var listOfPeople = new ListOfPeople();
            listOfPeople.ListOfPersons = new List<People>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] arrInput = input.Split();
                string name = arrInput[0];
                string id = arrInput[1];
                int age = int.Parse(arrInput[2]);

                var currentPerson = new People(name, id, age);
                listOfPeople.ListOfPersons.Add(currentPerson);
            }
            var sortedList = listOfPeople.ListOfPersons.OrderBy(x => x.Age).ToList();

            foreach (var person in sortedList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
