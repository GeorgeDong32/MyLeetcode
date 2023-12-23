/*
 * @lc app=leetcode.cn id=1078 lang=csharp
 *
 * [1078] Bigram 分词
 */

// @lc code=start
public class Solution
{
    public string[] FindOcurrences(string text, string first, string second)
    {
        var words = text.Split(" ");
        var ans = new List<string>();
        for (var i = 2; i < words.Length; i++)
        {
            if (words[i - 2] == first && words[i - 1] == second)
            {
                ans.Add(words[i]);
            }
        }
        return ans.ToArray();
    }
}
// @lc code=end

