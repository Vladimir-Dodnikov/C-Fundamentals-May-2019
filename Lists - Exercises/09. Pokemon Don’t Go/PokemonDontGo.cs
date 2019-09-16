using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    class PokemonDontGo
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            int sumSequence = 0;
            

            while (sequence.Count != 0)
            {
                if (sequence.Count == 0)
                {
                    break;
                }
                int index = int.Parse(Console.ReadLine());
                int valueKeeper = 0;

                if (index < 0)
                {
                    valueKeeper = sequence[0];
                    sequence[0] = sequence[sequence.Count - 1];
                    sumSequence += valueKeeper;
                }
                else if (index > (sequence.Count - 1))
                {
                    valueKeeper = sequence[sequence.Count - 1];
                    sequence[sequence.Count - 1] = sequence[0];
                    sumSequence += valueKeeper;
                }
                else
                {
                    valueKeeper = sequence.ElementAt(index);
                    sequence.RemoveAt(index);
                    sumSequence += valueKeeper;
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= valueKeeper)
                    {
                        sequence[i] += valueKeeper;
                    }
                    else
                    {
                        sequence[i] -= valueKeeper;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", sumSequence));

        }
    }
}
