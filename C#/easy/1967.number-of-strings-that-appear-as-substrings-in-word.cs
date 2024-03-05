/*
 * @lc app=leetcode.cn id=1967 lang=csharp
 * @lcpr version=30118
 *
 * [1967] 作为子字符串出现在单词中的字符串数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumOfStrings(string[] patterns, string word)
    {
        return patterns.Where(pattern => word.Contains(pattern)).Count();
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["a","abc","bc","d"]\n"abc"\n
// @lcpr case=end

// @lcpr case=start
// ["a","b","c"]\n"aaaaabbbbb"\n
// @lcpr case=end

// @lcpr case=start
// ["a","a","a"]\n"ab"\n
// @lcpr case=end

 */

