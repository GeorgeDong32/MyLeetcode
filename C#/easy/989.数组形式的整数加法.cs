/*
 * @lc app=leetcode.cn id=989 lang=csharp
 *
 * [989] 数组形式的整数加法
 */

// @lc code=start
public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var res = new List<int>();
        int n = num.Length;
        for (int i = n - 1; i >= 0 || k > 0; i--, k /= 10)
        {
            if (i >= 0) k += num[i];
            res.Add(k % 10);
        }
        res.Reverse();
        return res;
    }
}
// @lc code=end

