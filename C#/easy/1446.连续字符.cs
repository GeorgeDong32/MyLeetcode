/*
 * @lc app=leetcode.cn id=1446 lang=csharp
 *
 * [1446] 连续字符
 */

// @lc code=start
public class Solution
{
    public int MaxPower(string s)
    {
        var enerage = 1;
        var max = 1;
        var last = s[0];
        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == last)
            {
                enerage++;
                max = Math.Max(enerage, max);
            }
            else
            {
                max = Math.Max(enerage, max);
                enerage = 1;
            }
            last = s[i];
        }
        return max;
    }
}
// @lc code=end

