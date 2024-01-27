/*
 * @lc app=leetcode.cn id=1539 lang=csharp
 *
 * [1539] 第 k 个缺失的正整数
 */

// @lc code=start
public class Solution
{
    public int FindKthPositive(int[] arr, int k)
    {
        return Enumerable.Range(1, arr.Length + k).Except(arr).ElementAt(k - 1);
    }
}
// @lc code=end

