/*
 * @lc app=leetcode.cn id=1935 lang=csharp
 * @lcpr version=30118
 *
 * [1935] 可以输入的最大单词数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        var broken = brokenLetters.ToCharArray().Distinct();
        var split = text.Split(" ");
        return split.Count(s => !broken.Any(c => s.Contains(c)));
    }
}
// @lc code=end



/*
// @lcpr case=start
// "hello world"\n"ad"\n
// @lcpr case=end

// @lcpr case=start
// "leet code"\n"lt"\n
// @lcpr case=end

// @lcpr case=start
// "leet code"\n"e"\n
// @lcpr case=end

 */

