/*
 * @lc app=leetcode.cn id=1784 lang=csharp
 * @lcpr version=30116
 *
 * [1784] 检查二进制字符串字段
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckOnesSegment(string s)
    {
        return !s.Contains("01");
    }
}
// @lc code=end



/*
// @lcpr case=start
// "1001"\n
// @lcpr case=end

// @lcpr case=start
// "110"\n
// @lcpr case=end

 */

