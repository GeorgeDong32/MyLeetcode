/*
 * @lc app=leetcode.cn id=1394 lang=csharp
 *
 * [1394] 找出数组中的幸运数
 */

// @lc code=start
public class Solution
{
    public int FindLucky(int[] arr)
    {
        return arr.GroupBy(x => x)
                  .Where(g => g.Key == g.Count())
                  .Select(g => g.Key)
                  .DefaultIfEmpty(-1)
                  .Max();
    }
}
// @lc code=end

