/*
 * @lc app=leetcode.cn id=2798 lang=csharp
 * @lcpr version=30122
 *
 * [2798] 满足目标工作时长的员工数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        return hours.Count(h => h >= target);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [0,1,2,3,4]\n2\n
// @lcpr case=end

// @lcpr case=start
// [5,1,4,2,2]\n6\n
// @lcpr case=end

 */

