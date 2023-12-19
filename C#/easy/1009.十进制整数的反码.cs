/*
 * @lc app=leetcode.cn id=1009 lang=csharp
 *
 * [1009] 十进制整数的反码
 */

// @lc code=start
public class Solution
{
    public int BitwiseComplement(int n)
    {
        int sum = 1;
        while (sum < n)
        {
            sum = sum * 2 + 1;
        }
        return sum - n;
    }
}
// @lc code=end

