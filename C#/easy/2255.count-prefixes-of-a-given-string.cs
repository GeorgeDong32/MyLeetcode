/*
 * @lc app=leetcode.cn id=2255 lang=csharp
 * @lcpr version=30120
 *
 * [2255] 统计是给定字符串前缀的字符串数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountPrefixes(string[] words, string s)
    {
        return words.Where(w => s.StartsWith(w)).Count();
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["a","b","c","ab","bc","abc"]\n"abc"\n
// @lcpr case=end

// @lcpr case=start
// ["a","a"]\n"aa"\n
// @lcpr case=end

 */

