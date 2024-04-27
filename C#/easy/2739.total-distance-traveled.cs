/*
 * @lc app=leetcode.cn id=2739 lang=csharp
 * @lcpr version=30122
 *
 * [2739] 总行驶距离
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int DistanceTraveled(int mainTank, int additionalTank)
    {
        var addc = (mainTank - 1) / 4;
        return (mainTank + Math.Min(addc, additionalTank)) * 10;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 5\n10\n
// @lcpr case=end

// @lcpr case=start
// 1\n2\n
// @lcpr case=end

 */

