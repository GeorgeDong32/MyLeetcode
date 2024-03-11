/*
 * @lc app=leetcode.cn id=2053 lang=csharp
 * @lcpr version=30119
 *
 * [2053] 数组中第 K 个独一无二的字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string KthDistinct(string[] arr, int k)
    {
        var dict = new Dictionary<string, int>();
        var pool = new List<string>();
        foreach (var s in arr)
        {
            if (!dict.TryAdd(s, 1))
            {
                dict[s]++;
                pool.Remove(s);
            }
            else
            {
                pool.Add(s);
            }
        }
        if (pool.Count < k)
        {
            return "";
        }
        return pool[k - 1];
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["d","b","c","b","c","a"]\n2\n
// @lcpr case=end

// @lcpr case=start
// ["aaa","aa","a"]\n1\n
// @lcpr case=end

// @lcpr case=start
// ["a","b","a"]\n3\n
// @lcpr case=end

 */

