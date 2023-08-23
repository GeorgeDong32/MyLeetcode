/*
 * @lc app=leetcode.cn id=389 lang=csharp
 *
 * [389] 找不同
 */

// @lc code=start
public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        var res = 0;
        for (var i = 0; i < s.Length; i++)
        {
            res ^= s[i];
            res ^= t[i];
        }
        res ^= t[t.Length - 1];
        return (char)res;
    }
}
// @lc code=end

