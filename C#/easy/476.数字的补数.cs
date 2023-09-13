/*
 * @lc app=leetcode.cn id=476 lang=csharp
 *
 * [476] 数字的补数
 */

// @lc code=start
public class Solution
{
    public int FindComplement(int num)
    {
        long temp = 1;
        int result = num;
        while (num != 0)
        {
            num >>= 1;
            temp *= 2;
        }
        return Math.Abs((int)(result - temp + 1));
    }
}
// @lc code=end

