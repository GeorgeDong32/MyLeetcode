/*
 * @lc app=leetcode.cn id=1413 lang=csharp
 *
 * [1413] 逐步求和得到正数的最小值
 */

// @lc code=start
public class Solution
{
    public int MinStartValue(int[] nums)
    {
        //找数组和的最小值，startValue是 1 - 最小值 
        var min = MinSum(nums);
        return 1 - min > 0 ? 1 - min : 1;
    }

    private int MinSum(int[] nums)
    {
        var l = nums.Length; var min = 9999; var sum = 0;
        for (var i = 0; i < l; i++)
        {
            sum += nums[i];
            min = sum < min ? sum : min;
        }
        return min;
    }
}
// @lc code=end

