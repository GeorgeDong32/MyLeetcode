/*
 * @lc app=leetcode.cn id=977 lang=csharp
 *
 * [977] 有序数组的平方
 */

// @lc code=start
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var sq = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            sq[i] = nums[i] * nums[i];
        }
        Array.Sort(sq);
        return sq;
    }
}
// @lc code=end

