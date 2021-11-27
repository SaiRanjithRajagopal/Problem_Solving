using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Container_With_Most_Water
    {
        public static int maxArea(int[] height) //1,8,6,2,5,4,8,3,7
        {
            int water = 0, left = 0, right = height.Length - 1;

            while (left < right)
            {
                water = Math.Max(water, Math.Min(height[left], height[right]) * (right - left));
                if (height[left] > height[right]) right--;
                else left++;
                Console.WriteLine($"Water - {water}; Left - {left}; Right - {right}");
            }
            return water;
        }

        public static int Ranjith_Style_Max_Area(int[] height)
        {
            int maximumUnit = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int pointer = i + 1;
                while (pointer < height.Length)
                {
                    if (Math.Min(height[i], height[pointer]) * (pointer - i) > maximumUnit)
                    {
                        maximumUnit = Math.Min(height[i], height[pointer]) * (pointer - i);
                    }
                    pointer++;
                }
            }
            return maximumUnit;
        }
    }
}
