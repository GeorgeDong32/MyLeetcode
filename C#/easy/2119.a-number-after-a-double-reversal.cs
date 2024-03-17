/*
 * @lc app=leetcode.cn id=2119 lang=csharp
 * @lcpr version=30119
 *
 * [2119] 反转两次的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsSameAfterReversals(int num)
    {
        var numstr = num.ToString();
        return numstr.Length == 1 || numstr[numstr.Length - 1] != '0';
    }
}
// @lc code=end



/*
// @lcpr case=start
// 526\n
// @lcpr case=end

// @lcpr case=start
// 1800\n
// @lcpr case=end

// @lcpr case=start
// 0\n
// @lcpr case=end

 */

