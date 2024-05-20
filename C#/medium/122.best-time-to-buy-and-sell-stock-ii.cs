/*
 * @lc app=leetcode.cn id=122 lang=csharp
 * @lcpr version=30202
 *
 * [122] 买卖股票的最佳时机 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var ans = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            ans += Math.Max(0, prices[i] - prices[i - 1]);
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [7,1,5,3,6,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,5]\n
// @lcpr case=end

// @lcpr case=start
// [7,6,4,3,1]\n
// @lcpr case=end

 */

