/*
 * @lc app=leetcode.cn id=1385 lang=csharp
 *
 * [1385] 两个数组间的距离值
 */

// @lc code=start
public class Solution
{
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        return arr1.Count(x => arr2.All(y => Math.Abs(x - y) > d));
    }
}
// @lc code=end

