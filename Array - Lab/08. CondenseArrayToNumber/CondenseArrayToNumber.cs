using System;
using System.Linq;

namespace _08._CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            while (nums.Length > 1)
            {
                int[] condense = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length-1; i++)
                {
                    condense[i] = nums[i] + nums[i + 1];

                }

                nums = condense;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
