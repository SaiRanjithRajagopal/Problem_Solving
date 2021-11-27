using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Longest_Substring_Without_Repeating_Characters
    {
        public static int Find_Longest_String(string receivedString)
        {
            char[] Longest_String_ToChar = receivedString.ToCharArray();

            HashSet<int> findDuplicate = new HashSet<int>();
            int currentMax = 0;

            foreach (char currentChar in Longest_String_ToChar)
            {
                if (!findDuplicate.Contains(currentChar))
                {
                    findDuplicate.Add(currentChar);
                }
                else
                {
                    if (findDuplicate.Count > currentMax)
                    {
                        currentMax = findDuplicate.Count;
                    }
                    findDuplicate.Clear();
                }
            }

            return currentMax;
        }
    }
}
