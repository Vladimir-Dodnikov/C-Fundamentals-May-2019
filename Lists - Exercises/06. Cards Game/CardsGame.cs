using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class CardsGame
    {
        static void Main()
        {
            List<int> playerOneCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> playerTwoCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (playerOneCards[0] > playerTwoCards[0])
                {
                    playerOneCards.Add(playerOneCards[0]);
                    playerOneCards.Add(playerTwoCards[0]);
                }
                else if (playerOneCards[0] < playerTwoCards[0])
                {
                    playerTwoCards.Add(playerTwoCards[0]);
                    playerTwoCards.Add(playerOneCards[0]);
                }

                playerOneCards.Remove(playerOneCards[0]);
                playerTwoCards.Remove(playerTwoCards[0]);

                if (playerOneCards.Count == 0)
                {
                    int sum = playerTwoCards.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (playerTwoCards.Count == 0)
                {
                    int sum = playerOneCards.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }

            }
        }
    }
}
