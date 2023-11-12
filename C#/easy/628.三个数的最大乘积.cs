/*
 * @lc app=leetcode.cn id=628 lang=csharp
 *
 * [628] 三个数的最大乘积
 */

// @lc code=start
public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        var l = nums.Length;
        Array.Sort(nums);
        return Math.Max(nums[l - 1] * nums[l - 2] * nums[l - 3], nums[0] * nums[1] * nums[l - 1]);
    }
}
// @lc code=end

