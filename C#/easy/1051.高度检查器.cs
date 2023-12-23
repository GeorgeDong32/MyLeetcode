/*
 * @lc app=leetcode.cn id=1051 lang=csharp
 *
 * [1051] 高度检查器
 */

// @lc code=start
public class Solution
{
    public int HeightChecker(int[] heights)
    {
        var expected = new int[heights.Length];
        Array.Copy(heights, expected, heights.Length);
        Array.Sort(expected);
        var count = 0;
        for (var i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
                count++;
        }
        return count;
    }
}
// @lc code=end

