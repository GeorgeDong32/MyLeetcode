/*
 * @lc app=leetcode.cn id=551 lang=csharp
 *
 * [551] 学生出勤记录 I
 */

// @lc code=start
public class Solution
{
    public bool CheckRecord(string s)
    {
        var a1 = s.IndexOf("A");
        var a2 = s.LastIndexOf("A");
        var ll = s.Contains("LLL");
        return !ll & (a1 == a2);
    }
}
// @lc code=end

