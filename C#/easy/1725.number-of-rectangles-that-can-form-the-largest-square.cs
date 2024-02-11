/*
 * @lc app=leetcode.cn id=1725 lang=csharp
 * @lcpr version=30116
 *
 * [1725] 可以形成最大正方形的矩形数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        var maxsq = rectangles.Select(rect => Math.Min(rect[0], rect[1])).ToArray();
        return maxsq.Count(sq => sq == maxsq.Max());
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[5,8],[3,9],[5,12],[16,5]]\n
// @lcpr case=end

// @lcpr case=start
// [[2,3],[3,7],[4,3],[3,7]]\n
// @lcpr case=end

 */

