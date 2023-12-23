/*
 * @lc app=leetcode.cn id=1047 lang=csharp
 *
 * [1047] 删除字符串中的所有相邻重复项
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string RemoveDuplicates(string s)
    {
        var sb = new StringBuilder();
        foreach (var c in s)
        {
            if (sb.Length > 0 && c == sb[sb.Length - 1])
            {
                sb.Remove(sb.Length - 1, 1);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
// @lc code=end

