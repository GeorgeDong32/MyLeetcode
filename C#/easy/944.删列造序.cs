/*
 * @lc app=leetcode.cn id=944 lang=csharp
 *
 * [944] 删列造序
 */

// @lc code=start
public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        var x = strs[0].Length;
        var y = strs.Length;
        var count = 0;
        for (var i = 0; i < x; i++)
        {
            for (var j = 0; j < y - 1; j++)
            {
                if (strs[j][i] > strs[j + 1][i])
                {
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}
// @lc code=end

