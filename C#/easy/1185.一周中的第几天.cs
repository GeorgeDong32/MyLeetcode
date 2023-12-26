/*
 * @lc app=leetcode.cn id=1185 lang=csharp
 *
 * [1185] 一周中的第几天
 */

// @lc code=start
public class Solution
{
    public string DayOfTheWeek(int day, int month, int year)
    {
        var date = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
        var temp = DateTime.Parse(date).DayOfWeek;
        return temp.ToString();
    }
}
// @lc code=end

