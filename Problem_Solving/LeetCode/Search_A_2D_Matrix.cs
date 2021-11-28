using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Search_A_2D_Matrix
    {
        int[][] matrix;
        public Search_A_2D_Matrix()
        {
            matrix = new int[][] {
                new int[] { 1,  4,  7,  11, 15 },
                new int[] { 2,  5,  8,  12, 19 },
                new int[] { 3,  6,  9,  16, 22 },
                new int[] { 10, 13, 14, 17, 24 },
                new int[] { 18, 21, 23, 26, 30 }
            };
        }

        public bool SearchMatrix(int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int k = i; k < matrix[i].Length; k++)
                {
                    if (matrix[i][k] == target) return true;
                }
            }
            return false;
        }
    }
}
