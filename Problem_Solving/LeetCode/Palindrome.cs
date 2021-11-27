using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Palindrome
    {
        public static bool Verify_Palidrome(int num)
        {
            int result = 0, sum = 0, verify = num;
            while (num > 0)
            {
                result = num % 10;
                sum = (sum * 10) + result;
                num = num / 10;
            }

            return sum == verify;
        }
    }
}
