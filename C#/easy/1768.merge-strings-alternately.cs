/*
 * @lc app=leetcode.cn id=1768 lang=csharp
 * @lcpr version=30122
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
        var sb = new StringBuilder();
        var i = 0;
        for (i = 0; i < word1.Length && i < word2.Length; i++)
        {
            sb.Append(word1[i]);
            sb.Append(word2[i]);
        }
        if (i == word1.Length)
        {
            sb.Append(word2.Substring(i, word2.Length - word1.Length));
        }
        else
        {
            sb.Append(word1.Substring(i, word1.Length - word2.Length));
        }
        return sb.ToString();
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

