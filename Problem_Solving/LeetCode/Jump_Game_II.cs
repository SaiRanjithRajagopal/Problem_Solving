using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    //https://www.youtube.com/watch?v=cETfFsSTGJI&ab_channel=TusharRoy-CodingMadeSimple
    class Jump_Game_II
    {
        public int Jump(int[] nums)
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
            }
            return noOfJumps[nums.Length-1];
        }
    }
}
