/*
 * @lc app=leetcode.cn id=1704 lang=csharp
 * @lcpr version=30116
 *
 * [1704] 判断字符串的两半是否相似
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public static HashSet<char> dict = ['a', 'e', 'i', 'o', 'u'];
    public bool HalvesAreAlike(string s)
    {
        var left = s.Substring(0, s.Length / 2).ToLower();
        var right = s.Substring(s.Length / 2, s.Length / 2).ToLower();
        return left.Count(c => dict.Contains(c)) == right.Count(c => dict.Contains(c));
    }
}
// @lc code=end



/*
// @lcpr case=start
// "book"\n
// @lcpr case=end

// @lcpr case=start
// "textbook"\n
// @lcpr case=end

 */

