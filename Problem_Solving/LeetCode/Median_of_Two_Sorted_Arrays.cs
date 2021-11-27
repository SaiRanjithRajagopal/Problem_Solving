using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Median_of_Two_Sorted_Arrays
    {
        public static float Median(int[] ArrayOne, int[] ArrayTwo)
        {
            float value = 0;
            int[] finalArray = ArrayOne.Concat(ArrayTwo).ToArray();

            Array.Sort(finalArray);

            if ((finalArray.Length % 2) == 0) //1,2,3,4
            {
                value = finalArray[(finalArray.Length / 2) - 1] + finalArray[(finalArray.Length / 2)];
                value = value / 2;
            }
            else
            {
                value = finalArray[finalArray.Length / 2];
            }
            return value;
        }
    }
}
