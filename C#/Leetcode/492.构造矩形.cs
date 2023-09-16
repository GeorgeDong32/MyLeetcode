/*
 * @lc app=leetcode.cn id=492 lang=csharp
 *
 * [492] 构造矩形
 */

// @lc code=start
public class Solution
{
    public int[] ConstructRectangle(int area)
    {
        int w = (int)Math.Sqrt(area);
        while (area % w != 0)
        {
            --w;
        }
        return new int[] { area / w, w };
    }
}
// @lc code=end

