/*
 * @lc app=leetcode.cn id=2828 lang=csharp
 *
 * [2828] 判别首字母缩略词
 */

// @lc code=start
public class Solution
{
    public bool IsAcronym(IList<string> words, string s)
    {
        if (words.Count != s.Length)
            return false;
        var s1 = "";
        foreach (var word in words)
        {
            s1 += word[0];
        }
        return s1 == s;
    }
}
// @lc code=end

