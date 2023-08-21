/*
 * @lc app=leetcode.cn id=290 lang=csharp
 *
 * [290] 单词规律
 */

// @lc code=start
using System.Text;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var sa = s.Split(' ');
        if (sa.Length != pattern.Length)
        {
            return false;
        }
        StringBuilder s1 = new StringBuilder();
        StringBuilder s2 = new StringBuilder();
        for (int i = 0; i < pattern.Length; i++)
        {
            s1.Append(pattern.IndexOf(pattern[i]));
            // s2.Append(sArr.IndexOf(sArr[i]));//c#里没有这个方法
            s2.Append(Array.IndexOf(sa, sa[i]));
        }
        return s1.ToString() == s2.ToString();
    }
}
// @lc code=end

