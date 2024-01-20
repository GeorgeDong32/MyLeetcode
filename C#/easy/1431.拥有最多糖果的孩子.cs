/*
 * @lc app=leetcode.cn id=1431 lang=csharp
 *
 * [1431] 拥有最多糖果的孩子
 */

// @lc code=start
public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var ans = new List<bool>();
        var max = candies.Max();
        foreach (var c in candies)
        {
            ans.Add(max - c <= extraCandies);
        }
        return ans;
    }
}
// @lc code=end

