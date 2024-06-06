/*
 * @lc app=leetcode.cn id=343 lang=csharp
 * @lcpr version=30202
 *
 * [343] 整数拆分
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int IntegerBreak(int n)
    {
        var dp = new int[n + 1];
        dp[2] = 1;
        for (int i = 3; i <= n; i++)
        {
            for (int j = 1; j <= i / 2; j++)
            {
                dp[i] = Math.Max(dp[i], Math.Max((i - j) * j, dp[i - j] * j));
            }
        }
        return dp[n];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n
// @lcpr case=end

// @lcpr case=start
// 10\n
// @lcpr case=end

 */

