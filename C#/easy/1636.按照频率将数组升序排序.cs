/*
 * @lc app=leetcode.cn id=1636 lang=csharp
 *
 * [1636] 按照频率将数组升序排序
 */

// @lc code=start
public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        return nums.GroupBy(num => num).OrderBy(g => g.Count()).ThenByDescending(g => g.Key).SelectMany(g => g).ToArray();
    }
}
// @lc code=end

