using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Jump_Game
    {
        public bool Jump(int[] nums)
        {
            int[] noOfJumps = new int[nums.Length];
            int minimumStep = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                while (minimumStep < i)
                {
                    if ((nums[minimumStep] + noOfJumps[minimumStep]) >= i)
                    {
                        noOfJumps[i] = noOfJumps[minimumStep] + 1;
                        minimumStep = 0;
                        break;
                    }
                    minimumStep++;
                }
                if (minimumStep == i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
