/*
 * @lc app=leetcode.cn id=1403 lang=csharp
 *
 * [1403] 非递增顺序的最小子序列
 */

// @lc code=start
public class Solution
{
    public IList<int> MinSubsequence(int[] nums)
    {
        Array.Sort(nums);
        int total = nums.Sum(), sum = 0;
        var res = new List<int>();
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            sum += nums[i];
            res.Add(nums[i]);
            if (sum > total - sum)
            {
                return res;
            }
        }
        return res;
    }
}
// @lc code=end

