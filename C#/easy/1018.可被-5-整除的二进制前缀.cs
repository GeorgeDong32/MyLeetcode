/*
 * @lc app=leetcode.cn id=1018 lang=csharp
 *
 * [1018] 可被 5 整除的二进制前缀
 */

// @lc code=start
using System.Numerics;

public class Solution
{
    public IList<bool> PrefixesDivBy5(int[] nums)
    {
        var ans = new List<bool>();
        int n = nums.Length;
        BigInteger[] presum = new BigInteger[n];
        presum[0] = nums[0];
        ans.Add(nums[0] % 5 == 0);
        for (int i = 1; i < n; i++)
        {
            presum[i] = 2 * presum[i - 1] + nums[i];
            ans.Add(presum[i] % 5 == 0);
        }
        return ans;
    }
}
// @lc code=end

