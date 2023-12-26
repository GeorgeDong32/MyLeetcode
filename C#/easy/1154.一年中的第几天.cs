/*
 * @lc app=leetcode.cn id=1154 lang=csharp
 *
 * [1154] 一年中的第几天
 */

// @lc code=start
public class Solution
{
    public int DayOfYear(string date)
    {
        return DateTime.Parse(date).DayOfYear;
    }
}
// @lc code=end

