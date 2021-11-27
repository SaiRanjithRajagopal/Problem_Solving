using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Daily_Temperatures
    {
        public static int[] Temperatures(int[] temperatures)
        {
            int[] warmerDay = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                warmerDay[i] = FindRightMaximum(temperatures, i + 1, temperatures[i]);
            }
            return warmerDay;
        }

        public static int FindRightMaximum(int[] temp, int incrementValue, int currentDay_Temp)
        {
            int maxValue = 0;
            bool found = false;
            while (incrementValue < temp.Length)
            {
                if (temp[incrementValue] > currentDay_Temp)
                {
                    found = true;
                    return ++maxValue;
                }
                else
                {
                    maxValue++;
                }
                incrementValue++;
            }
            return found == true ? maxValue : 0;
        }
    }
}
