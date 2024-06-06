/*
 * @lc app=leetcode.cn id=96 lang=csharp
 * @lcpr version=30202
 *
 * [96] 不同的二叉搜索树
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumTrees(int n)
    {
        var dp = new int[n + 1];
        dp[0] = 1;
        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= i; j++)
            {
                dp[i] += dp[j - 1] * dp[i - j];
            }
        }
        return dp[n];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n
// @lcpr case=end

// @lcpr case=start
// 1\n
// @lcpr case=end

 */

