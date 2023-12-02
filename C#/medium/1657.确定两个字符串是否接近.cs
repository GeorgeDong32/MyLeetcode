/*
 * @lc app=leetcode.cn id=1657 lang=csharp
 *
 * [1657] 确定两个字符串是否接近
 */

// @lc code=start
public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;
        int[] c1 = new int[26]; int[] c2 = new int[26];
        var l = word1.Length;
        for (var i = 0; i < l; i++)
        {
            c1[word1[i] - 'a']++;
            c2[word2[i] - 'a']++;
        }
        for (int i = 0; i < 26; i++)
        {
            if (c1[i] > 0 && c2[i] == 0 || c1[i] == 0 && c2[i] > 0)
            {
                return false;
            }
        }
        Array.Sort(c1); Array.Sort(c2);
        return Enumerable.SequenceEqual(c1, c2);
    }
}
// @lc code=end

