/*
 * @lc app=leetcode.cn id=844 lang=csharp
 *
 * [844] 比较含退格的字符串
 */

// @lc code=start
using System.Text;

public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        return Equals(ProcessString(s), ProcessString(t));
    }

    public string ProcessString(string s)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '#')
            {
                sb.Append(s[i]);
            }
            else if (s[i] == '#' && sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
        }
        return sb.ToString();
    }
}
// @lc code=end

