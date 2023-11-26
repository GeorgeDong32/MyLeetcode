/*
 * @lc app=leetcode.cn id=724 lang=csharp
 *
 * [724] 寻找数组的中心下标
 */

// @lc code=start
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int total = nums.Sum(); var sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (sum * 2 + nums[i] == total)
                return i;
            sum += nums[i];
        }
        return -1;
    }
}
// @lc code=end

