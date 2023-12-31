/*
 * @lc app=leetcode.cn id=1281 lang=csharp
 *
 * [1281] 整数的各位积和之差
 */

// @lc code=start
public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        var sum = 0; var prod = 1; var temp = 0;
        while (n > 0)
        {
            temp = n % 10;
            sum += temp;
            prod *= temp;
            n /= 10;
        }
        return prod - sum;
    }
}
// @lc code=end

