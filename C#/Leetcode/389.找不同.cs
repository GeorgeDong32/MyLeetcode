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
        var count = new int[26];
        if (string.IsNullOrEmpty(s))
        {
            return t[0];
        }
        for (var i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']--;
            count[t[i] - 'a']++;
        }
        count[t[t.Length - 1] - 'a']++;
        for (var i = 0; i < count.Length; i++)
        {
            if (count[i] == 1)
                return (char)(i + 'a');
        }
        return 'a';
    }
}
// @lc code=end

