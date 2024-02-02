/*
 * @lc app=leetcode.cn id=1608 lang=csharp
 *
 * [1608] 特殊数组的特征值
 */

// @lc code=start
public class Solution
{
    public int SpecialArray(int[] nums)
    {
        var ans = Enumerable.Range(1, nums.Length).SingleOrDefault(x => nums.Count(num => num >= x) == x);
        return ans == 0 ? -1 : ans;
    }
}
// @lc code=end

