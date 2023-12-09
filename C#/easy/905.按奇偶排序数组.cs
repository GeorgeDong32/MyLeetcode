/*
 * @lc app=leetcode.cn id=905 lang=csharp
 *
 * [905] 按奇偶排序数组
 */

// @lc code=start
public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        var ans = new List<int>();
        foreach (var num in nums)
        {
            if (num % 2 == 0)
                ans.Insert(0, num);
            else
                ans.Add(num);
        }
        return ans.ToArray();
    }
}
// @lc code=end

