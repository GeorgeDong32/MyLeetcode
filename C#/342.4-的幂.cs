/*
 * @lc app=leetcode.cn id=342 lang=csharp
 *
 * [342] 4的幂
 */

// @lc code=start
using System.Reflection.Metadata.Ecma335;

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0)
            return false;
        while (n % 4 == 0)
            n /= 4;
        return n == 1;
    }
}
// @lc code=end

