using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Trappin_Rain_Water
    {
        public static int Trap(int[] bar)  //[0,1,0,2,1,0,1,3,2,1,2,1] 
        {
            int counter = 0;
            int rainWater = 0;
            while (counter < bar.Length)
            {
                int leftMax = FindLeftMaximum(bar, counter);
                int rightMax = FindRightMaximum(bar, counter + 1);
                int minValue = Math.Min(leftMax, rightMax);

                if ((minValue - bar[counter] * 1) > 0)
                {
                    rainWater = rainWater + (minValue - bar[counter] * 1);
                }

                counter++;
            }
            return rainWater;
        }

        public static int FindLeftMaximum(int[] bar, int incrementValue)
        {
            int counter = 0;
            int maximumValue = bar[0];
            while (counter < incrementValue)
            {
                if (bar[counter] >= maximumValue)
                {
                    maximumValue = bar[counter];
                }
                counter++;
            }
            return maximumValue;
        }

        public static int FindRightMaximum(int[] bar, int incrementValue)
        {
            int maxValue = 0;
            while (incrementValue < bar.Length)
            {
                if (bar[incrementValue] >= maxValue)
                {
                    maxValue = bar[incrementValue];
                }
                incrementValue++;
            }
            return maxValue;
        }
    }
}
