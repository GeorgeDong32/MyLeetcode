/*
 * @lc app=leetcode.cn id=1736 lang=csharp
 * @lcpr version=30116
 *
 * [1736] 替换隐藏数字得到的最晚时间
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string MaximumTime(string time)
    {
        var split = time.Split(":");
        var ans = new StringBuilder();
        if (split[0][0] == '?')
        {
            if (split[0][1] - '0' >= 4 && split[0][1] != '?')
                ans.Append('1');
            else
                ans.Append('2');
        }
        else
            ans.Append(split[0][0]);
        if (split[0][1] == '?')
        {
            if (ans[0] == '2')
                ans.Append('3');
            else
                ans.Append('9');
        }
        else
            ans.Append(split[0][1]);
        ans.Append(':');
        if (split[1][0] == '?')
            ans.Append('5');
        else
            ans.Append(split[1][0]);
        if (split[1][1] == '?')
            ans.Append('9');
        else
            ans.Append(split[1][1]);
        return ans.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "2?:?0"\n
// @lcpr case=end

// @lcpr case=start
// "0?:3?"\n
// @lcpr case=end

// @lcpr case=start
// "1?:22"\n
// @lcpr case=end

 */

