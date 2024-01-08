/*
 * @lc app=leetcode.cn id=2894 lang=csharp
 *
 * [2894] 分类求和并作差
 */

// @lc code=start
public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        var range = Enumerable.Range(1, n);
        var sum2 = range.Where(x => x % m == 0).Sum();
        var sum1 = range.Where(x => x % m != 0).Sum();
        return sum1 - sum2;
    }
}
// @lc code=end

