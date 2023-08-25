/*
 * @lc app=leetcode.cn id=441 lang=csharp
 *
 * [441] 排列硬币
 */

// @lc code=start
public class Solution
{
    public int ArrangeCoins(int n)
    {
        for (var i = 1; i <= n; i++)
        {
            n -= i;
            if (n < i + 1)
            {
                return i;
            }
        }
        return 0;
    }
}
// @lc code=end

