/*
 * @lc app=leetcode.cn id=1005 lang=csharp
 *
 * [1005] K 次取反后最大化的数组和
 */

// @lc code=start
public class Solution
{
    public int LargestSumAfterKNegations(int[] nums, int k)
    {
        Array.Sort(nums);
        for (var i = k; i > 0; i--)
        {
            nums[0] *= -1;
            Array.Sort(nums);
        }
        return nums.Sum();
    }
}
// @lc code=end

