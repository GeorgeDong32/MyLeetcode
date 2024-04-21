/*
 * @lc app=leetcode.cn id=151 lang=csharp
 * @lcpr version=30122
 *
 * [151] 反转字符串中的单词
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string ReverseWords(string s)
    {
        var split = s.Trim().Split();
        split = split.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).ToArray();
        Array.Reverse(split);
        return string.Join(" ", split);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "the sky is blue"\n
// @lcpr case=end

// @lcpr case=start
// "  hello world  "\n
// @lcpr case=end

// @lcpr case=start
// "a good   example"\n
// @lcpr case=end

 */

