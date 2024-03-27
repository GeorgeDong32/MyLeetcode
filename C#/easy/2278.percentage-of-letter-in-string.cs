/*
 * @lc app=leetcode.cn id=2278 lang=csharp
 * @lcpr version=30120
 *
 * [2278] 字母在字符串中的百分比
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int PercentageLetter(string s, char letter)
    {
        var count = s.Count(x => x == letter);
        return count * 100 / s.Length;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "foobar"\n"o"\n
// @lcpr case=end

// @lcpr case=start
// "jjjj"\n"k"\n
// @lcpr case=end

 */

