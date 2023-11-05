/*
 * @lc app=leetcode.cn id=561 lang=csharp
 *
 * [561] 数组拆分
 */

// @lc code=start
public class Solution
{
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);
        var sum = 0;
        for (var i = 0; i < nums.Length / 2; i++)
        {
            sum += nums[2 * i];
        }
        return sum;
    }
}
// @lc code=end

