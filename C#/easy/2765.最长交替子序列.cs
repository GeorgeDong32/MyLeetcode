/*
 * @lc app=leetcode.cn id=2765 lang=csharp
 *
 * [2765] 最长交替子序列
 */

// @lc code=start
public class Solution
{
    public int AlternatingSubarray(int[] nums)
    {
        int res = -1;
        int n = nums.Length;
        int firstIndex = 0;
        for (int i = 1; i < n; i++)
        {
            int length = i - firstIndex + 1;
            if (nums[i] - nums[firstIndex] == (length - 1) % 2)
            {
                res = Math.Max(res, length);
            }
            else
            {
                if (nums[i] - nums[i - 1] == 1)
                {
                    firstIndex = i - 1;
                    res = Math.Max(res, 2);
                }
                else
                {
                    firstIndex = i;
                }
            }
        }
        return res;
    }
}
// @lc code=end

