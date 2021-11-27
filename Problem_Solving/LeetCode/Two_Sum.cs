using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Two_Sum
    {
        int[] numbers = null;

        public Two_Sum(int[] num)
        {
            numbers = num;
        }

        public int[] AddSum(int target)
        {
            Dictionary<int, int> value = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int result = target - numbers[i];

                if (value.ContainsValue(result))
                {
                    return new int[] { value.Where(x => x.Value == result).First().Key, i };
                }
                else
                {
                    value.Add(i, numbers[i]);
                }
            }
            return null;
        }
    }
}
