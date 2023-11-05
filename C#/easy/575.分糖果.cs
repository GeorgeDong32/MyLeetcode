/*
 * @lc app=leetcode.cn id=575 lang=csharp
 *
 * [575] 分糖果
 */

// @lc code=start
public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        var left = 0;
        var right = 0;
        var t = 1;
        Array.Sort(candyType);
        for (var i = 0; i < candyType.Length; i++)
        {
            if (candyType[left] != candyType[right])
            {
                left = right;
                t++;
            }
            right++;
        }
        return t > candyType.Length / 2 ? candyType.Length / 2 : t;
    }
}
// @lc code=end

