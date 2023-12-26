/*
 * @lc app=leetcode.cn id=1160 lang=csharp
 *
 * [1160] 拼写单词
 */

// @lc code=start
public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        var ca = new int[26];
        var ans = 0;
        foreach (var c in chars)
        {
            ca[c - 'a']++;
        }
        var count = new int[26];
        var flag = true;
        foreach (var word in words)
        {
            Array.Fill(count, 0);
            flag = true;
            foreach (var c in word)
            {
                count[c - 'a']++;
                if (count[c - 'a'] > ca[c - 'a'])
                    flag = false;
            }
            if (flag)
                ans += word.Length;
        }
        return ans;
    }
}
// @lc code=end

