using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class KaminoFactory
    {
        static void Main()
        {
            int sampleLength = int.Parse(Console.ReadLine());

            int[] bestSemple = new int[sampleLength];
            int bestSampleStartOfSequence = sampleLength;
            int bestSampleSequenseLenght = 0;
            int bestSampleSum = 0;
            int bestSampleNumber = 0;

            string inputSequence = Console.ReadLine();

            int sampleCounter = 0;

            while (inputSequence != "Clone them!")
            {
                sampleCounter++;

                int[] currentSample = inputSequence
                                      .Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

                int currentSampleSum = currentSample.Sum();

                int currentSampleStartOfSequence = 0;
                int currentSampleSequenseLenght = 0;

                for (int i = 0; i < currentSample.Length - 1; i++)
                {
                    int currentStart = i;
                    int currentSequenceLength = 1;

                    for (int j = i + 1; j < currentSample.Length; j++)
                    {
                        if (currentSample[i] == 1 && currentSample[j] == 1)
                        {
                            currentSequenceLength++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentSequenceLength > currentSampleSequenseLenght)
                    {
                        currentSampleStartOfSequence = currentStart;
                        currentSampleSequenseLenght = currentSequenceLength;
                    }
                }

                if (currentSampleSequenseLenght > bestSampleSequenseLenght)
                {
                    bestSampleStartOfSequence = currentSampleStartOfSequence;
                    bestSampleSequenseLenght = currentSampleSequenseLenght;
                    bestSampleSum = currentSampleSum;
                    bestSemple = currentSample;
                    bestSampleNumber = sampleCounter;
                }
                else if (currentSampleSequenseLenght == bestSampleSequenseLenght)
                {
                    if (currentSampleStartOfSequence < bestSampleStartOfSequence)
                    {
                        bestSampleStartOfSequence = currentSampleStartOfSequence;
                        bestSampleSequenseLenght = currentSampleSequenseLenght;
                        bestSampleSum = currentSampleSum;
                        bestSemple = currentSample;
                        bestSampleNumber = sampleCounter;
                    }
                    else if (currentSampleStartOfSequence == bestSampleStartOfSequence)
                    {
                        if (currentSampleSum > bestSampleSum)
                        {
                            bestSampleStartOfSequence = currentSampleStartOfSequence;
                            bestSampleSequenseLenght = currentSampleSequenseLenght;
                            bestSampleSum = currentSampleSum;
                            bestSemple = currentSample;
                            bestSampleNumber = sampleCounter;
                        }
                    }
                }

                inputSequence = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSampleSum}.");
            Console.WriteLine(string.Join(" ", bestSemple));
        }
    }
}
