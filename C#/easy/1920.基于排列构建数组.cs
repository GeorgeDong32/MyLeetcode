/*
 * @lc app=leetcode.cn id=1920 lang=csharp
 *
 * [1920] 基于排列构建数组
 */

// @lc code=start
public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        return Enumerable.Range(0, nums.Length).Select(i => nums[nums[i]]).ToArray();
    }
}
// @lc code=end

