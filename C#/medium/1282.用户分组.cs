/*
 * @lc app=leetcode.cn id=1282 lang=csharp
 *
 * [1282] 用户分组
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var groups = new Dictionary<int, List<int>>();
        var result = new List<IList<int>>();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!groups.ContainsKey(groupSizes[i]))
            {
                groups[groupSizes[i]] = new List<int>();
            }
            groups[groupSizes[i]].Add(i);
            if (groups[groupSizes[i]].Count == groupSizes[i])
            {
                result.Add(groups[groupSizes[i]]);
                groups[groupSizes[i]] = new List<int>();
            }
        }
        return result;
    }
}
// @lc code=end

