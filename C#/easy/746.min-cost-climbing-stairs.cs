/*
 * @lc app=leetcode.cn id=746 lang=csharp
 * @lcpr version=30122
 *
 * [746] 使用最小花费爬楼梯
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var n = cost.Length;
        //move right
        var dp = new int[3];
        dp[0] = 0; dp[1] = 0; dp[2] = 0;
        for (var i = 2; i <= n; i++)
        {
            dp[0] = Math.Min(dp[1] + cost[i - 1], dp[2] + cost[i - 2]);
            dp[2] = dp[1];
            dp[1] = dp[0];
        }
        return dp[0];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [10,15,20]\n
// @lcpr case=end

// @lcpr case=start
// [1,100,1,1,1,100,1,1,100,1]\n
// @lcpr case=end

 */

