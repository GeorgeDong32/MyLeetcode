/*
 * @lc app=leetcode.cn id=1523 lang=csharp
 *
 * [1523] 在区间范围内统计奇数数目
 */

// @lc code=start
public class Solution
{
    public int CountOdds(int low, int high)
    {
        return low % 2 == 0 && high % 2 == 0 ? (high - low) / 2 : (high - low) / 2 + 1;
    }
}
// @lc code=end

