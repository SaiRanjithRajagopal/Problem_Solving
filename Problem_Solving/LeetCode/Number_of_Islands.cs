using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    //https://www.youtube.com/watch?v=__98uL6wst8&ab_channel=TECHDOSE
    class Number_of_Islands
    {
        char[][] islandGrid;
        public Number_of_Islands()
        {
            islandGrid = new char[][] {
                    new char[] {'1','1','1','1','0'},
                    new char[] {'1','1','0','1','0'},
                    new char[] {'1','1','0','0','0'},
                    new char[] {'0','0','0','0','0'}
                };
        }

        public int NumIslands() //  public int NumIslands(char[][] islandGrid)
        {
            int totalNumberOfIsland = 0;

            for (int i = 0; i < islandGrid.Length; i++)
            {
                for (int j = i; j < islandGrid[i].Length; j++)
                {
                    if (islandGrid[i][j] == '1')
                    {
                        Find_Adjacent_Island(islandGrid, i, j);
                        totalNumberOfIsland = totalNumberOfIsland + 1;
                    }
                }
            }
            return totalNumberOfIsland;
        }

        private void Find_Adjacent_Island(char[][] islandGrid, int row, int column)
        {
            if (row < 0 || column < 0 || column  >= islandGrid[row].Length ||
                islandGrid[row][column] == '2' || islandGrid[row][column] == '0')
            {
                return;
            }
            if (islandGrid[row][column] == '1')
            {
                islandGrid[row][column] = '2';
            }
            //Top
            Find_Adjacent_Island(islandGrid, row - 1, column - 1);
            //Down
            Find_Adjacent_Island(islandGrid, row + 1, column);
            //Left
            Find_Adjacent_Island(islandGrid, row, column-1);
            //Right
            Find_Adjacent_Island(islandGrid, row, column+1);
        }
    }
}
