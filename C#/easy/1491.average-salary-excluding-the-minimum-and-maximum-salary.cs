/*
 * @lc app=leetcode.cn id=1491 lang=csharp
 * @lcpr version=30122
 *
 * [1491] 去掉最低工资和最高工资后的工资平均值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public double Average(int[] salary)
    {
        return (double)(salary.Sum() - salary.Max() - salary.Min()) / (salary.Length - 2);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4000,3000,1000,2000]\n
// @lcpr case=end

// @lcpr case=start
// [1000,2000,3000]\n
// @lcpr case=end

// @lcpr case=start
// [6000,5000,4000,3000,2000,1000]\n
// @lcpr case=end

// @lcpr case=start
// [8000,9000,2000,3000,6000,1000]\n
// @lcpr case=end

 */

