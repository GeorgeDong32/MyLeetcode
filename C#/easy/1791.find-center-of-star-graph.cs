/*
 * @lc app=leetcode.cn id=1791 lang=csharp
 * @lcpr version=30116
 *
 * [1791] 找出星型图的中心节点
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindCenter(int[][] edges)
    {
        var count = new int[edges.Length + 2];
        foreach (var e in edges)
        {
            count[e[0]]++;
            count[e[1]]++;
        }
        return count.Select((x, i) => new { Index = i, Value = x })
                 .FirstOrDefault(x => x.Value == edges.Length).Index;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,2],[2,3],[4,2]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,2],[5,1],[1,3],[1,4]]\n
// @lcpr case=end

 */

