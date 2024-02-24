/*
 * @lc app=leetcode.cn id=1859 lang=csharp
 * @lcpr version=30117
 *
 * [1859] 将句子排序
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text.RegularExpressions;

public class Solution
{
    public string SortSentence(string s)
    {
        var split = s.Split(" ");
        split = split.OrderBy(s => s[s.Length - 1]).ToArray();
        var ans = string.Join(' ', split);
        return Regex.Replace(ans, @"\d", "");
    }
}
// @lc code=end



/*
// @lcpr case=start
// "is2 sentence4 This1 a3"\n
// @lcpr case=end

// @lcpr case=start
// "Myself2 Me1 I4 and3"\n
// @lcpr case=end

 */

