/*
 * @lc app=leetcode.cn id=2000 lang=csharp
 * @lcpr version=30118
 *
 * [2000] 反转单词前缀
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        var index = word.IndexOf(ch);
        if (index <= 0)
        {
            return word;
        }
        else
        {
            var str1 = word.Substring(0, index + 1);
            var str2 = word.Substring(index + 1, word.Length - index - 1);
            return ReverseStr(str1) + str2;
        }
    }

    private string ReverseStr(string s)
    {
        var sb = new StringBuilder();
        for (var i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abcdefd"\n"d"\n
// @lcpr case=end

// @lcpr case=start
// "xyxzxe"\n"z"\n
// @lcpr case=end

// @lcpr case=start
// "abcd"\n"z"\n
// @lcpr case=end

 */

