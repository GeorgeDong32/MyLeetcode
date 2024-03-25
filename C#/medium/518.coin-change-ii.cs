/*
 * @lc app=leetcode.cn id=518 lang=csharp
 * @lcpr version=30120
 *
 * [518] 零钱兑换 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Change(int amount, int[] coins)
    {
        var dp = new int[5001];
        dp[0] = 1;
        foreach (var coin in coins)
        {
            for (var i = coin; i <= amount; i++)
            {
                dp[i] += dp[i - coin];
            }
        }
        return dp[amount];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 5\n[1, 2, 5]\n
// @lcpr case=end

// @lcpr case=start
// 3\n[2]\n
// @lcpr case=end

// @lcpr case=start
// 10\n[10]\n
// @lcpr case=end

 */

