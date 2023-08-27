/*
 * @lc app=leetcode.cn id=459 lang=csharp
 *
 * [459] 重复的子字符串
 */

// @lc code=start
public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        var temp = s + s;
        temp = temp.Substring(1, temp.Length - 2);
        return temp.Contains(s);
    }
}
// @lc code=end

