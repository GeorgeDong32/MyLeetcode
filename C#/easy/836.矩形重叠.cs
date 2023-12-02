/*
 * @lc app=leetcode.cn id=836 lang=csharp
 *
 * [836] 矩形重叠
 */

// @lc code=start
public class Solution
{
    public bool IsRectangleOverlap(int[] rec1, int[] rec2)
    {
        //右端点的最小值大于左端点的最大值意味着左侧矩形右端点必然在右侧矩形左端点的右侧可能导致重叠，再判定Y方向即可
        return Math.Min(rec1[2], rec2[2]) > Math.Max(rec1[0], rec2[0]) && Math.Min(rec1[3], rec2[3]) > Math.Max(rec1[1], rec2[1]);
    }
}
// @lc code=end

