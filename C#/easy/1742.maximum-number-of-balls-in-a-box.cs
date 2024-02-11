/*
 * @lc app=leetcode.cn id=1742 lang=csharp
 * @lcpr version=30116
 *
 * [1742] 盒子中小球的最大数量
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountBalls(int lowLimit, int highLimit)
    {
        return Enumerable.Range(lowLimit, highLimit - lowLimit + 1)
            .Select(i => i.ToString().Sum(c => c - '0'))
            .GroupBy(x => x)
            .Max(g => g.Count());
    }
}
// @lc code=end



/*
// @lcpr case=start
// 1\n10\n
// @lcpr case=end

// @lcpr case=start
// 5\n15\n
// @lcpr case=end

// @lcpr case=start
// 19\n28\n
// @lcpr case=end

 */

