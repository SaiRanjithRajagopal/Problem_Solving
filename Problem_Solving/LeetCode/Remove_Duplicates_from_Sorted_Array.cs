using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Remove_Duplicates_from_Sorted_Array
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int currentValue = -1;
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != currentValue)
                {
                    currentValue = nums[i];
                    counter++;
                }
                else
                {
                    nums[i] = nums[i + 1]; //error
                }
            }
            return counter;

        }

        public static int RemoveDuplicates_Inbuilt(int[] nums)
        {
            nums = nums.ToList().Distinct().ToArray();
            return nums.Length;
        }
    }
}
