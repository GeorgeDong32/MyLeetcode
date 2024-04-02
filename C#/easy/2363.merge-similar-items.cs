/*
 * @lc app=leetcode.cn id=2363 lang=csharp
 * @lcpr version=30121
 *
 * [2363] 合并相似的物品
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (int[] v in items1)
        {
            dictionary.TryAdd(v[0], 0);
            dictionary[v[0]] += v[1];
        }
        foreach (int[] v in items2)
        {
            dictionary.TryAdd(v[0], 0);
            dictionary[v[0]] += v[1];
        }

        var res = new List<IList<int>>();
        foreach (var kv in dictionary)
        {
            int k = kv.Key, v = kv.Value;
            res.Add(new List<int> { k, v });
        }
        res.Sort((a, b) => a[0] - b[0]);
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,1],[4,5],[3,8]]\n[[3,1],[1,5]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,1],[3,2],[2,3]]\n[[2,1],[3,2],[1,3]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,3],[2,2]]\n[[7,1],[2,2],[1,4]]\n
// @lcpr case=end

 */

