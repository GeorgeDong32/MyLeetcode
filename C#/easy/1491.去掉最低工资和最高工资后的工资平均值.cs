/*
 * @lc app=leetcode.cn id=1491 lang=csharp
 *
 * [1491] 去掉最低工资和最高工资后的工资平均值
 */

// @lc code=start
public class Solution
{
    public double Average(int[] salary)
    {
        return (double)(salary.Sum() - salary.Max() - salary.Min()) / (salary.Length - 2);
    }
}
// @lc code=end

