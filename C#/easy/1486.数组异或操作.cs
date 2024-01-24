/*
 * @lc app=leetcode.cn id=1486 lang=csharp
 *
 * [1486] 数组异或操作
 */

// @lc code=start
public class Solution
{
    public int XorOperation(int n, int start)
    {
        return (start & 3) < 2 ? ((n & 1) == 0) ? (n & 3) : (start + 2 * n - 3 + (n & 3)) : ((n & 1) == 0) ? ((start + (n - 1) * 2) ^ (start - 2 + (n & 3))) : (start + 1 - (n & 3));
    }
}
// @lc code=end

