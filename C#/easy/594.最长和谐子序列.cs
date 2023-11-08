/*
 * @lc app=leetcode.cn id=594 lang=csharp
 *
 * [594] 最长和谐子序列
 */

// @lc code=start
public class Solution
{
    public int FindLHS(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        var res = 0;
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
                dict.Add(num, 1);
            else
                dict[num]++;
        }
        foreach (var pair in dict)
        {
            if (dict.ContainsKey(pair.Key - 1))
            {
                res = Math.Max(res, pair.Value + dict[pair.Key - 1]);
            }
        }
        return res;
    }
}
// @lc code=end

