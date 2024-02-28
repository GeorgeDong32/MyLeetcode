/*
 * @lc app=leetcode.cn id=1941 lang=csharp
 * @lcpr version=30117
 *
 * [1941] 检查是否所有字符出现次数相同
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool AreOccurrencesEqual(string s)
    {
        var ans = s.GroupBy(c => c).Select(g => g.Count());
        return ans.Distinct().Count() == 1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abacbc"\n
// @lcpr case=end

// @lcpr case=start
// "aaabb"\n
// @lcpr case=end

 */

