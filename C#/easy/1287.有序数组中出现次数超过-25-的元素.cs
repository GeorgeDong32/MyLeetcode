/*
 * @lc app=leetcode.cn id=1287 lang=csharp
 *
 * [1287] 有序数组中出现次数超过25%的元素
 */

// @lc code=start
public class Solution
{
    public int FindSpecialInteger(int[] arr)
    {
        var dict = new Dictionary<int, int>();
        var flag = true;
        foreach (var n in arr)
        {
            flag = dict.TryAdd(n, 1);
            if (!flag)
            {
                dict[n]++;
                if (dict[n] > arr.Length / 4)
                    return n;
            }
        }
        return arr[0];
    }
}
// @lc code=end

