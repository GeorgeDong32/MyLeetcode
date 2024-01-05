/*
 * @lc app=leetcode.cn id=1360 lang=csharp
 *
 * [1360] 日期之间隔几天
 */

// @lc code=start
public class Solution
{
    public int DaysBetweenDates(string date1, string date2)
    {
        var d1 = DateTime.Parse(date1); var d2 = DateTime.Parse(date2);
        var ts = d1 - d2;
        return Math.Abs(ts.Days);
    }
}
// @lc code=end

