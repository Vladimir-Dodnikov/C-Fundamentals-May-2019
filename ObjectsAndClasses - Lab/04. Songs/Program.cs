using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Songs
{
    class Songs
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //II Defining Simple Classes
            int numberOfSongs = int.Parse(Console.ReadLine());

            var songs = new List<Songs>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Songs song = new Songs();
                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string readTypeToPrint = Console.ReadLine();

            if (readTypeToPrint == "all")
            {
                foreach (Songs item in songs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else 
            {
                foreach (Songs item in songs)
                {
                    if (item.TypeList == readTypeToPrint)
                    {
                        Console.WriteLine(item.Name);
                    }
                   
                }
            }
        }
    }
}
