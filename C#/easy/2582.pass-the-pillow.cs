/*
 * @lc app=leetcode.cn id=2582 lang=csharp
 * @lcpr version=30121
 *
 * [2582] 递枕头
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int PassThePillow(int n, int time)
    {
        return (time / (n - 1)) % 2 == 0 ? time % (n - 1) + 1 : n - time % (n - 1);
    }
}
// @lc code=end



/*
// @lcpr case=start
// 4\n5\n
// @lcpr case=end

// @lcpr case=start
// 3\n2\n
// @lcpr case=end

 */

