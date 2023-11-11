/*
 * @lc app=leetcode.cn id=599 lang=csharp
 *
 * [599] 两个列表的最小索引总和
 */

// @lc code=start
public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var dict = new Dictionary<string, int>();
        var res = new List<string>();
        var minl = list1.Length + list2.Length;
        var cnt = 0;
        foreach (var it in list1)
        {
            dict.Add(it, cnt);
            cnt++;
        }
        cnt = 0;
        foreach (var it in list2)
        {
            if (dict.ContainsKey(it))
            {
                dict[it] += cnt;
                if (dict[it] < minl)
                {
                    minl = dict[it];
                    res.Clear();
                    res.Add(it);
                }
                else if (dict[it] == minl)
                {
                    res.Add(it);
                }
            }
            cnt++;
        }
        return res.ToArray();
    }
}
// @lc code=end

