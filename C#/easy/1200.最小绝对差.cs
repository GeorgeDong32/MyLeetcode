/*
 * @lc app=leetcode.cn id=1200 lang=csharp
 *
 * [1200] 最小绝对差
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);
        IList<IList<int>> ans = new List<IList<int>>();
        var l = arr.Length;
        var min = 99999999;
        for (var i = 0; i < l - 1; i++)
        {
            min = Math.Min(min, arr[i + 1] - arr[i]);
        }
        for (int i = 1; i < l; i++)
        {
            if (arr[i] - arr[i - 1] == min)
            {
                IList<int> pair = new List<int>();
                pair.Add(arr[i - 1]);
                pair.Add(arr[i]);
                ans.Add(pair);
            }
        }
        return ans;
    }
}
// @lc code=end

