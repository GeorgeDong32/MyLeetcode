/*
 * @lc app=leetcode.cn id=1370 lang=csharp
 *
 * [1370] 上升下降字符串
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string SortString(string s)
    {
        var counts = new int[26];
        //统计源字符串中的字符出现频率。
        foreach (var ch in s)
        {
            counts[ch - 'a']++;
        }
        var result = new StringBuilder();
        while (result.Length < s.Length)
        {
            for (var i = 0; i < 26; i++)
            {
                if (counts[i] > 0)
                {
                    result.Append((char)(i + 'a'));
                    counts[i]--;
                }
            }
            for (var i = 25; i >= 0; i--)
            {
                if (counts[i] > 0)
                {
                    result.Append((char)(i + 'a'));
                    counts[i]--;
                }
            }
        }

        return result.ToString();
    }
}
// @lc code=end

