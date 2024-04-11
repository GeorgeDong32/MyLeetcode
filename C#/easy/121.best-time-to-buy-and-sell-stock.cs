/*
 * @lc app=leetcode.cn id=121 lang=csharp
 * @lcpr version=30121
 *
 * [121] 买卖股票的最佳时机
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var lmin = prices[0]; var maxprofit = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            maxprofit = Math.Max(maxprofit, prices[i] - lmin);
            lmin = Math.Min(lmin, prices[i]);
        }
        return maxprofit;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [7,1,5,3,6,4]\n
// @lcpr case=end

// @lcpr case=start
// [7,6,4,3,1]\n
// @lcpr case=end

 */

