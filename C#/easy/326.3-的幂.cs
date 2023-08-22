/*
 * @lc app=leetcode.cn id=326 lang=csharp
 *
 * [326] 3 的幂
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0)
            return false;
        while (n % 3 == 0)
            n /= 3;
        return n == 1;
    }
}
// @lc code=end

