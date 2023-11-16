/*
 * @lc app=leetcode.cn id=645 lang=csharp
 *
 * [645] 错误的集合
 */

// @lc code=start
public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        var dup = -1; var missing = -1;
        for (var i = 0; i < nums.Length; i++)
        {
            var index = Math.Abs(nums[i]) - 1;
            if (nums[index] < 0)
                dup = Math.Abs(nums[i]);
            else
                nums[index] *= -1;
        }
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] > 0)
                missing = i + 1;

        return new int[] { dup, missing };
    }
}
// @lc code=end

