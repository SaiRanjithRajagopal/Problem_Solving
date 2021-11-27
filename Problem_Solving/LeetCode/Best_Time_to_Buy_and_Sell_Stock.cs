using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.LeetCode
{
    class Best_Time_to_Buy_and_Sell_Stock
    {
        public static int MaxProfit(int[] prices)
        {
            int maxValue = 0;
            for (int buy = 0; buy < prices.Length; buy++)
            {
                for (int sell = buy + 1; sell < prices.Length; sell++)
                {
                    if (prices[sell] - prices[buy] > maxValue)
                    {
                        maxValue = prices[sell] - prices[buy];
                    }
                }
            }
            return maxValue;
        }
    }
}
