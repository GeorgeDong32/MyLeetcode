/*
 * @lc app=leetcode.cn id=1299 lang=csharp
 *
 * [1299] 将每个元素替换为右侧最大元素
 */

// @lc code=start
public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        var ans = new int[arr.Length];
        ans[arr.Length - 1] = -1;
        for (var i = arr.Length - 2; i >= 0; i--)
        {
            ans[i] = Math.Max(ans[i + 1], arr[i + 1]);
        }
        return ans;
    }
}
// @lc code=end

