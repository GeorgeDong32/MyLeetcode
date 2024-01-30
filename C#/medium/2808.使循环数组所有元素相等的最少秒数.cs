/*
 * @lc app=leetcode.cn id=2808 lang=csharp
 *
 * [2808] 使循环数组所有元素相等的最少秒数
 */

// @lc code=start
public class Solution
{
    public int MinimumSeconds(IList<int> nums)
    {
        IDictionary<int, IList<int>> dic = new Dictionary<int, IList<int>>();
        int n = nums.Count, res = n;
        for (int i = 0; i < n; ++i)
        {
            dic.TryAdd(nums[i], new List<int>());
            dic[nums[i]].Add(i);
        }
        foreach (IList<int> positions in dic.Values)
        {
            int mx = positions[0] + n - positions[positions.Count - 1];
            for (int i = 1; i < positions.Count; ++i)
            {
                mx = Math.Max(mx, positions[i] - positions[i - 1]);
            }
            res = Math.Min(res, mx / 2);
        }
        return res;
    }
}
// @lc code=end

