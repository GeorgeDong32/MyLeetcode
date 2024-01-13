/*
 * @lc app=leetcode.cn id=2085 lang=csharp
 *
 * [2085] 统计出现过一次的公共字符串
 */

// @lc code=start
public class Solution
{
    public int CountWords(string[] words1, string[] words2)
    {
        var c1 = new Dictionary<string, int>();
        var c2 = new Dictionary<string, int>();
        var flag = true;
        foreach (var w in words1)
        {
            flag = c1.TryAdd(w, 1);
            if (!flag)
            {
                c1[w]++;
            }
        }
        foreach (var w in words2)
        {
            flag = c2.TryAdd(w, 1);
            if (!flag)
            {
                c2[w]++;
            }
        }
        return c1.Where(x => x.Value == 1 && c2.ContainsKey(x.Key) && c2[x.Key] == 1).Count();
    }
}
// @lc code=end

