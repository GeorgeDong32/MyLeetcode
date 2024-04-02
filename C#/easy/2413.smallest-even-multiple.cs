/*
 * @lc app=leetcode.cn id=2413 lang=csharp
 * @lcpr version=30121
 *
 * [2413] 最小偶倍数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SmallestEvenMultiple(int n)
    {
        return n % 2 != 1 ? n : 2 * n;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 5\n
// @lcpr case=end

// @lcpr case=start
// 6\n
// @lcpr case=end

 */

