/*
 * @lc app=leetcode.cn id=70 lang=csharp
 * @lcpr version=30202
 *
 * [70] 爬楼梯
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int ClimbStairs(int n)
    {
        var dp = new int[n + 1];
        dp[0] = 1; dp[1] = 1;
        for (var i = 2; i < n + 1; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
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
// 3\n
// @lcpr case=end

 */

