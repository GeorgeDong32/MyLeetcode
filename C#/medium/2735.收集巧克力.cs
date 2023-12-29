/*
 * @lc app=leetcode.cn id=2735 lang=csharp
 *
 * [2735] 收集巧克力
 */

// @lc code=start
public class Solution
{
    public long MinCost(int[] nums, int x)
    {
        int n = nums.Length;
        int[] f = new int[n];
        Array.Copy(nums, 0, f, 0, n);
        long ans = GetSum(f);
        for (int k = 1; k < n; ++k)
        {
            for (int i = 0; i < n; ++i)
            {
                f[i] = Math.Min(f[i], nums[(i + k) % n]);
            }
            ans = Math.Min(ans, (long)k * x + GetSum(f));
        }
        return ans;
    }

    public long GetSum(int[] f)
    {
        long sum = 0;
        foreach (int num in f)
        {
            sum += num;
        }
        return sum;
    }
}
// @lc code=end

