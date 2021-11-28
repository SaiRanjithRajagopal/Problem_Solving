using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Longest_Valid_Parentheses
    {
        public int LongestValidParentheses(string s)
        {
            char[] paranthese = s.Replace("(",")").ToCharArray();
            int reminder = paranthese.Length % 2;
            if (reminder == 1)
            {
                return paranthese.Length - 1;
            }
            else
            {
                return (((paranthese.Length / 2) - 1) * 2);
            }
        }
    }
}
