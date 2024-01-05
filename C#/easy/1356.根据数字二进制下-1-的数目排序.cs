/*
 * @lc app=leetcode.cn id=1356 lang=csharp
 *
 * [1356] 根据数字二进制下 1 的数目排序
 */

// @lc code=start
public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        return arr.OrderBy(x => Convert.ToString(x, 2).Count(c => c == '1')).ThenBy(x => x).ToArray();
    }
}
// @lc code=end

