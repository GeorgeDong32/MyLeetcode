/*
 * @lc app=leetcode.cn id=2481 lang=csharp
 * @lcpr version=30121
 *
 * [2481] 分割圆的最少切割次数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumberOfCuts(int n)
    {
        return n == 1 ? 0 : n % 2 == 0 ? n / 2 : n;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 4\n
// @lcpr case=end

// @lcpr case=start
// 3\n
// @lcpr case=end

 */

