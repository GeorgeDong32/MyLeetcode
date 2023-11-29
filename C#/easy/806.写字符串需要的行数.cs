/*
 * @lc app=leetcode.cn id=806 lang=csharp
 *
 * [806] 写字符串需要的行数
 */

// @lc code=start
public class Solution
{
    public int[] NumberOfLines(int[] widths, string s)
    {
        var line = 1; var count = 0;
        foreach (var c in s)
        {
            var temp = widths[c - 'a'];
            if (count + temp > 100)
            {
                line++; count = temp;
            }
            else
            {
                count += temp;
            }
        }
        return new int[] { line, count };
    }
}
// @lc code=end

