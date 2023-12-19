/*
 * @lc app=leetcode.cn id=746 lang=csharp
 *
 * [746] 使用最小花费爬楼梯
 */

// @lc code=start
public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var min = new int[cost.Length + 2];
        min[0] = 0; min[1] = 0;
        for (var i = 2; i <= cost.Length; i++)
        {
            min[i] = Math.Min(min[i - 1] + cost[i - 1], min[i - 2] + cost[i - 2]);
        }
        return min[cost.Length];
    }
}
// @lc code=end

