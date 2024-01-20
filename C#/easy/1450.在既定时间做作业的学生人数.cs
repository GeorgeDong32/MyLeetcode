/*
 * @lc app=leetcode.cn id=1450 lang=csharp
 *
 * [1450] 在既定时间做作业的学生人数
 */

// @lc code=start
public class Solution
{
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
    {
        var count = 0;
        for (var i = 0; i < startTime.Length; i++)
        {
            if (startTime[i] > queryTime || endTime[i] < queryTime)
                continue;
            else
                count++;
        }
        return count;
    }
}
// @lc code=end

