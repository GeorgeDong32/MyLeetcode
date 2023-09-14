/*
 * @lc app=leetcode.cn id=485 lang=csharp
 *
 * [485] 最大连续 1 的个数
 */

// @lc code=start
public class Solution
{
    //烂方法
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        string s = "";
        for (var i = 0; i < nums.Length; i++)
        {
            s += $"{nums[i]}";
        }
        var sl = s.Split('0');
        int max = 0;
        foreach (var o in sl)
        {
            if (o.Length > max)
                max = o.Length;
        }
        return max;
    }
}
// @lc code=end

