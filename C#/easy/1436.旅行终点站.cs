/*
 * @lc app=leetcode.cn id=1436 lang=csharp
 *
 * [1436] 旅行终点站
 */

// @lc code=start
public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        if (paths.Count == 1)
        {
            return paths[0][1];
        }
        var dict = new Dictionary<string, int>();
        var flag = true;
        foreach (var path in paths)
        {
            flag = dict.TryAdd(path[0], -1);
            if (!flag)
                dict[path[0]]--;
            flag = dict.TryAdd(path[1], 1);
            if (!flag)
                dict[path[1]]++;
        }
        return dict.Where(kv => kv.Value == 1).First().Key;
    }
}
// @lc code=end

