/*
 * @lc app=leetcode.cn id=521 lang=csharp
 *
 * [521] 最长特殊序列 Ⅰ
 */

// @lc code=start
public class Solution
{
    public int FindLUSlength(string a, string b)
    {
        return !a.Equals(b) ? Math.Max(a.Length, b.Length) : -1;
    }
}
// @lc code=end

