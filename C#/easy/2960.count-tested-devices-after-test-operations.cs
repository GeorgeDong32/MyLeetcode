/*
 * @lc app=leetcode.cn id=2960 lang=csharp
 * @lcpr version=30201
 *
 * [2960] 统计已测试设备
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountTestedDevices(int[] batteryPercentages)
    {
        var ans = 0;
        foreach (var b in batteryPercentages)
        {
            ans += (b - ans) > 0 ? 1 : 0;
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,2,1,3]\n
// @lcpr case=end

// @lcpr case=start
// [0,1,2]\n
// @lcpr case=end

 */

