/*
 * @lc app=leetcode.cn id=1534 lang=csharp
 *
 * [1534] 统计好三元组
 */

// @lc code=start
public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        return Enumerable.Range(0, arr.Length - 2)
            .SelectMany(i => Enumerable.Range(i + 1, arr.Length - i - 1)
                .SelectMany(j => Enumerable.Range(j + 1, arr.Length - j - 1)
                    .Where(k => Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)))
            .Count();
    }
}
// @lc code=end

