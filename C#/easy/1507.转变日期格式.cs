/*
 * @lc app=leetcode.cn id=1507 lang=csharp
 *
 * [1507] 转变日期格式
 */

// @lc code=start
public class Solution
{
    public string ReformatDate(string date)
    {
        var months = new Dictionary<string, string> {
            {"Jan", "01"}, {"Feb", "02"}, {"Mar", "03"}, {"Apr", "04"},
            {"May", "05"}, {"Jun", "06"}, {"Jul", "07"}, {"Aug", "08"},
            {"Sep", "09"}, {"Oct", "10"}, {"Nov", "11"}, {"Dec", "12"}
        };
        var split = date.Split(" ");
        var day = split[0].Length == 3 ? "0" + split[0].Substring(0, 1) : split[0].Substring(0, 2);
        var month = months[split[1]];
        var year = split[2];
        return $"{year}-{month}-{day}";
    }
}
// @lc code=end

