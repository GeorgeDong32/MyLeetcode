/*
 * @lc app=leetcode.cn id=1122 lang=csharp
 *
 * [1122] 数组的相对排序
 */

// @lc code=start
public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        Dictionary<int, int> num2index = Enumerable.Range(0, arr2.Length).ToDictionary(p => arr2[p], p => p);
        return arr1.Where(p => num2index.ContainsKey(p)).OrderBy(p => num2index[p]).Concat(arr1.Where(p => !num2index.ContainsKey(p)).OrderBy(p => p)).ToArray();
    }
}
// @lc code=end

