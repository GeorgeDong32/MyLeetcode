/*
 * @lc app=leetcode.cn id=1768 lang=csharp
 * @lcpr version=30116
 *
 * [1768] 交替合并字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var ans = new StringBuilder();
        var ml = Math.Min(word1.Length, word2.Length);
        for (var i = 0; i < ml; i++)
        {
            ans.Append(word1[i]);
            ans.Append(word2[i]);
        }
        if (word1.Length > word2.Length)
        {
            ans.Append(word1.Substring(ml, word1.Length - ml));
        }
        else
        {
            ans.Append(word2.Substring(ml, word2.Length - ml));
        }
        return ans.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abc"\n"pqr"\n
// @lcpr case=end

// @lcpr case=start
// "ab"\n"pqrs"\n
// @lcpr case=end

// @lcpr case=start
// "abcd"\n"pq"\n
// @lcpr case=end

 */

