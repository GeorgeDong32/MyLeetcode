/*
 * @lc app=leetcode.cn id=1207 lang=csharp
 *
 * [1207] 独一无二的出现次数
 */

// @lc code=start
public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var set = new Dictionary<int, int>();
        var flag = true;
        foreach (var num in arr)
        {
            flag = set.TryAdd(num, 1);
            if (!flag)
            {
                set[num]++;
            }
        }
        return set.Keys.Count == set.Values.Distinct().Count();
    }
}
// @lc code=end

