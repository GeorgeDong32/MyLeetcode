/*
 * @lc app=leetcode.cn id=714 lang=csharp
 * @lcpr version=30202
 *
 * [714] 买卖股票的最佳时机含手续费
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices, int fee)
    {
        var porfitSell = 0;
        var profitHold = -prices[0];
        for (var i = 1; i < prices.Length; i++)
        {
            var profitSellNew = Math.Max(porfitSell, profitHold + prices[i] - fee);
            var profitHoldNew = Math.Max(profitHold, porfitSell - prices[i]);
            profitHold = profitHoldNew;
            porfitSell = profitSellNew;
        }
        return porfitSell;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1, 3, 2, 8, 4, 9]\n2\n
// @lcpr case=end

// @lcpr case=start
// [1,3,7,5,10,3]\n3\n
// @lcpr case=end

 */

