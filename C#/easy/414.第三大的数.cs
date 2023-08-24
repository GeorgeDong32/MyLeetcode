/*
 * @lc app=leetcode.cn id=414 lang=csharp
 *
 * [414] 第三大的数
 */

// @lc code=start
public class Solution
{
    public int ThirdMax(int[] nums)
    {
        var list = nums.Distinct().ToList();
        list.Sort();
        if (list.Count < 3)
            return list.Last();
        else
            return list[list.Count - 3];
    }
}
// @lc code=end

