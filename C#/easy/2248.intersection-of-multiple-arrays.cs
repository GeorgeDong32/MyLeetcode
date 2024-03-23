/*
 * @lc app=leetcode.cn id=2248 lang=csharp
 * @lcpr version=30119
 *
 * [2248] 多个数组求交集
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<int> Intersection(int[][] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var a in nums)
        {
            foreach (var n in a)
            {
                if (!dict.TryAdd(n, 1))
                    dict[n]++;
            }
        }
        var res = dict.Where(kv => kv.Value >= nums.Length).Select(kv => kv.Key).ToList();
        res.Sort();
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[3,1,2,4,5],[1,2,3,4],[3,4,5,6]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,2,3],[4,5,6]]\n
// @lcpr case=end

 */

