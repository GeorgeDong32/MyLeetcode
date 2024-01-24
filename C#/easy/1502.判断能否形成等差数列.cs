/*
 * @lc app=leetcode.cn id=1502 lang=csharp
 *
 * [1502] 判断能否形成等差数列
 */

// @lc code=start
public class Solution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);
        var sub = new int[arr.Length - 1];
        var st = arr[1] - arr[0];
        for (var i = 1; i < arr.Length; i++)
        {
            sub[i - 1] = Math.Abs(arr[i] - arr[i - 1]);
        }
        return !sub.Any(x => x != st);
    }
}
// @lc code=end

