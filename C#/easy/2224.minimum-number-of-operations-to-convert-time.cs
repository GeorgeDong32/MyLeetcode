/*
 * @lc app=leetcode.cn id=2224 lang=csharp
 * @lcpr version=30120
 *
 * [2224] 转化时间需要的最少操作数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    static int[] minutes = { 60, 15, 5, 1 };

    public int ConvertTime(string current, string correct)
    {
        int currentTime = ConvertToMinutes(current);
        int correctTime = ConvertToMinutes(correct);
        int difference = correctTime - currentTime;
        int operations = 0;
        foreach (int time in minutes)
        {
            operations += difference / time;
            difference %= time;
        }
        return operations;
    }

    public int ConvertToMinutes(string time)
    {
        int hour = (time[0] - '0') * 10 + time[1];
        int minute = (time[3] - '0') * 10 + time[4];
        return hour * 60 + minute;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "02:30"\n"04:35"\n
// @lcpr case=end

// @lcpr case=start
// "11:00"\n"11:01"\n
// @lcpr case=end

 */

