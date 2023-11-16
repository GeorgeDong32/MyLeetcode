/*
 * @lc app=leetcode.cn id=2656 lang=csharp
 *
 * [2656] K 个元素的最大和
 */

// @lc code=start
public class Solution
{
    public int MaximizeSum(int[] nums, int k)
    {
        Array.Sort(nums);
        var maxb = nums[nums.Length - 1];
        return maxb * k + SumArray(k);
    }

    static public int SumArray(int k)
    {
        double t = (double)(k - 1) / 2;
        double kk = k;
        return (int)(kk * t);
    }
}
// @lc code=end

