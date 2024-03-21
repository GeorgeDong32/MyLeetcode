/*
 * @lc app=leetcode.cn id=2185 lang=csharp
 * @lcpr version=30119
 *
 * [2185] 统计包含给定前缀的字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int PrefixCount(string[] words, string pref)
    {
        return words.Where(x => x.StartsWith(pref)).Count();
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["pay","attention","practice","attend"]\n"at"\n
// @lcpr case=end

// @lcpr case=start
// ["leetcode","win","loops","success"]\n"code"\n
// @lcpr case=end

 */

