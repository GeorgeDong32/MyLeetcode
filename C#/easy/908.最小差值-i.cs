/*
 * @lc app=leetcode.cn id=908 lang=csharp
 *
 * [908] 最小差值 I
 */

// @lc code=start
public class Solution
{
    public int SmallestRangeI(int[] nums, int k)
    {
        var p = nums.Max() - nums.Min();
        return Math.Max(0, p - 2 * k);
    }
}
// @lc code=end

