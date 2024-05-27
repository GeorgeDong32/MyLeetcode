/*
 * @lc app=leetcode.cn id=2225 lang=csharp
 * @lcpr version=30202
 *
 * [2225] 找出输掉零场或一场比赛的玩家
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        var ans = new List<int[]>();
        var record = new Dictionary<int, int>();
        foreach (var match in matches)
        {
            record.TryAdd(match[0], 0);
            record.TryAdd(match[1], 0);
            record[match[1]]++;
        }
        var allwin = record.Where(kv => kv.Value == 0).Select(kv => kv.Key).ToArray();
        var onelose = record.Where(kv => kv.Value == 1).Select(kv => kv.Key).ToArray();
        Array.Sort(allwin);
        Array.Sort(onelose);
        ans.Add(allwin);
        ans.Add(onelose);
        return ans.ToArray();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,3],[2,3],[3,6],[5,6],[5,7],[4,5],[4,8],[4,9],[10,4],[10,9]]\n
// @lcpr case=end

// @lcpr case=start
// [[2,3],[1,3],[5,4],[6,4]]\n
// @lcpr case=end

 */

