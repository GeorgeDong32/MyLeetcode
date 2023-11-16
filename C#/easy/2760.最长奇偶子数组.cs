/*
 * @lc app=leetcode.cn id=2760 lang=csharp
 *
 * [2760] 最长奇偶子数组
 */

// @lc code=start
using System.Globalization;

public class Solution
{
    public int LongestAlternatingSubarray(int[] nums, int threshold)
    {
        var n = nums.Length; var ans = 0; var i = 0;
        while (i < n)
        {
            if ((nums[i] % 2 != 0 || nums[i] > threshold) && ++i >= 0) continue;
            int j = i + 1, cur = nums[i] % 2;
            while (j < n)
            {
                if (nums[j] > threshold || nums[j] % 2 == cur) break;
                cur = nums[j++] % 2;
            }
            ans = Math.Max(ans, j - i);
            i = j;
        }
        return ans;
    }
}
// @lc code=end

