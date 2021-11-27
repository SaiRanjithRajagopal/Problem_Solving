using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Rob_House
    {
        public int Rob(int[] nums)
        {
            List<int> one = new List<int>();
            List<int> two = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    one.Add(nums[i]);
                }
                else
                {
                    two.Add(nums[i]);
                }
            }
            return one.Sum() > two.Sum() ? one.Sum() : two.Sum();
        }
    }
}

