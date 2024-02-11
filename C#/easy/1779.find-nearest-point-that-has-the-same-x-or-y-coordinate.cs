/*
 * @lc app=leetcode.cn id=1779 lang=csharp
 * @lcpr version=30116
 *
 * [1779] 找到最近的有相同 X 或 Y 坐标的点
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        int minDistance = int.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < points.Length; i++)
        {
            if (points[i][0] == x || points[i][1] == y)
            {
                int distance = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    minIndex = i;
                }
            }
        }
        return minIndex;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n4\n[[1,2],[3,1],[2,4],[2,3],[4,4]]\n
// @lcpr case=end

// @lcpr case=start
// 3\n4\n[[3,4]]\n
// @lcpr case=end

// @lcpr case=start
// 3\n4\n[[2,3]]\n
// @lcpr case=end

 */

