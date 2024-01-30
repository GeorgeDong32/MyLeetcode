/*
 * @lc app=leetcode.cn id=1566 lang=csharp
 *
 * [1566] 重复至少 K 次且长度为 M 的模式
 */

// @lc code=start
public class Solution
{
    public bool ContainsPattern(int[] arr, int m, int k)
    {
        if (m * k > arr.Length)
            return false;
        return Enumerable.Range(0, arr.Length - m * k + 1)
                         .Any(i => Enumerable.Range(0, m)
                                            .All(j => Enumerable.Range(1, k - 1)
                                                                .All(l => arr[i + j] == arr[i + j + l * m])));
    }
}
// @lc code=end

