/*
 * @lc app=leetcode.cn id=509 lang=csharp
 * @lcpr version=30202
 *
 * [509] 斐波那契数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Fib(int n)
    {
        var fb = new int[3];
        fb[0] = 0; fb[1] = 1; fb[2] = 1;
        if (n <= 2)
            return fb[n];
        while (n - 2 > 0)
        {
            fb[0] = fb[1];
            fb[1] = fb[2];
            fb[2] = fb[0] + fb[1];
            n--;
        }
        return fb[2];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n
// @lcpr case=end

// @lcpr case=start
// 3\n
// @lcpr case=end

// @lcpr case=start
// 4\n
// @lcpr case=end

 */

