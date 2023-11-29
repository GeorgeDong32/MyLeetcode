/*
 * @lc app=leetcode.cn id=771 lang=csharp
 *
 * [771] 宝石与石头
 */

// @lc code=start
public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var count = 0;
        foreach (var c in stones)
        {
            count += jewels.Count(ch => ch == c);
        }
        return count;
    }
}
// @lc code=end

