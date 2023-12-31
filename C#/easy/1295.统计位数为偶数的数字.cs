/*
 * @lc app=leetcode.cn id=1295 lang=csharp
 *
 * [1295] 统计位数为偶数的数字
 */

// @lc code=start
public class Solution
{
    public int FindNumbers(int[] nums)
    {
        var ans = 0;
        foreach (var num in nums)
        {
            if (num.ToString().Length % 2 == 0)
                ans++;
        }
        return ans;
    }
}
// @lc code=end

