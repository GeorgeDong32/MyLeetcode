/*
 * @lc app=leetcode.cn id=1619 lang=csharp
 *
 * [1619] 删除某些元素后的数组均值
 */

// @lc code=start
public class Solution
{
    public double TrimMean(int[] arr)
    {
        Array.Sort(arr);
        var fp = arr.Length * 0.05;
        var temp = arr.Where((x, i) => i >= fp && i <= arr.Length - fp - 1).ToList();
        return (double)temp.Sum() / temp.Count();
    }
}
// @lc code=end

