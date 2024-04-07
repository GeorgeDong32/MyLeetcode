/*
 * @lc app=leetcode.cn id=2418 lang=csharp
 * @lcpr version=30121
 *
 * [2418] 按身高排序
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        var dict = new List<KeyValuePair<string, int>>();
        for (var i = 0; i < names.Length; i++)
        {
            dict.Add(KeyValuePair.Create(names[i], heights[i]));
        }
        return dict.OrderByDescending(kv => kv.Value).Select(kv => kv.Key).ToArray();
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["Mary","John","Emma"]\n[180,165,170]\n
// @lcpr case=end

// @lcpr case=start
// ["Alice","Bob","Bob"]\n[155,185,150]\n
// @lcpr case=end

 */

