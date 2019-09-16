using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._TakeOrSkip_Rope
{
    class TakeOrSkipRope
    {
        static void Main()
        {
            List<char> encryptedMessage = Console.ReadLine().ToList();

            List<int> numbersList = new List<int>();
            List<string> nonNumbersList = new List<string>();

            for (int i = 0; i < encryptedMessage.Count; i++)
            {
                if (encryptedMessage[i] >= '0' && encryptedMessage[i] <= '9')
                {
                    numbersList.Add(int.Parse(encryptedMessage[i].ToString()));
                }
                else
                {
                    nonNumbersList.Add(encryptedMessage[i].ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else if (i % 2 == 1)
                {
                    skipList.Add(numbersList[i]);
                }
            }

            List<string> result = new List<string>();
            int indexForSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(nonNumbersList);

                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();

                result.Add(string.Join("", temp));

                indexForSkip += takeList[i] + skipList[i];
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
