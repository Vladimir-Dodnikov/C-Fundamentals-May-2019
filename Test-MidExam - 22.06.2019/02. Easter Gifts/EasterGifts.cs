using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Easter_Gifts
{
    class EasterGifts
    {
        static void Main()
        {
            List<string> gifts = Console.ReadLine()
                .Split()
                .ToList();

            string input = string.Empty;
            while ((input=Console.ReadLine()) != "No Money")
            {
                string[] commandArgs = input
                    .Split()
                    .ToArray();

                string command = commandArgs[0];

                if (command == "OutOfStock")
                {
                    string giftName = commandArgs[1];
                    for (int i = 0; i < gifts.Count; i++)
                    {
                        if (gifts.Contains(giftName))
                        {
                            gifts.Insert(gifts.IndexOf(giftName), "None");
                            gifts.Remove(giftName);
                        }
                    }
                }
                else if (command == "Required")
                {
                    string newGift = commandArgs[1];
                    int elementToReplace = int.Parse(commandArgs[2]);

                    if (elementToReplace >= 0 && elementToReplace <= gifts.Count - 1)
                    {
                        gifts.Insert(elementToReplace, newGift);
                        gifts.RemoveAt(elementToReplace + 1);
                    }
                }
                else if (command == "JustInCase")
                {
                    string gift = commandArgs[1];
                    gifts.Remove(gifts[gifts.Count - 1]);
                    gifts.Add(gift);
                }
            }
            for (int i = 0; i < gifts.Count; i++)
            {
                gifts.Remove("None");
            }
            Console.WriteLine(string.Join(" ", gifts));
        }
    }
}
