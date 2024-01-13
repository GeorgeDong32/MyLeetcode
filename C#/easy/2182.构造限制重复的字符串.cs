/*
 * @lc app=leetcode.cn id=2182 lang=csharp
 *
 * [2182] 构造限制重复的字符串
 */

// @lc code=start
public class Solution
{
    public string RepeatLimitedString(string s, int repeatLimit)
    {
        Span<int> count = stackalloc int[26];

        foreach (var c in s)
        {
            count[c - 'a']++;
        }
        Span<char> ret = stackalloc char[s.Length];
        var index = 0;
        var m = 0;
        for (int i = 25, j = 24; i >= 0 && j >= 0;)
        {
            if (count[i] == 0)
            {
                m = 0;
                i--;
            }
            else if (m < repeatLimit)
            {
                count[i]--;
                ret[index++] = (char)('a' + i);
                m++;
            }
            else if (j >= i || count[j] == 0)
                j--;
            else
            {
                count[j]--;
                ret[index++] = (char)('a' + j);
                m = 0;
            }
        }
        return ret[..index].ToString();
    }
}
// @lc code=end

