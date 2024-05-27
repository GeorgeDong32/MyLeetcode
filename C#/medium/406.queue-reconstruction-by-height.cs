/*
 * @lc app=leetcode.cn id=406 lang=csharp
 * @lcpr version=30202
 *
 * [406] 根据身高重建队列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        Array.Sort(people, (p1, p2) =>
        {
            if (p1[0] != p2[0])
                return p2[0] - p1[0];
            else
                return p1[1] - p2[1];
        });
        var reconstructQueue = new List<int[]>();
        foreach (var p in people)
        {
            var temp = p;
            reconstructQueue.Insert(temp[1], temp);
        }
        return [.. reconstructQueue];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[7,0],[4,4],[7,1],[5,0],[6,1],[5,2]]\n
// @lcpr case=end

// @lcpr case=start
// [[6,0],[5,0],[4,0],[3,2],[2,2],[1,4]]\n
// @lcpr case=end

 */

