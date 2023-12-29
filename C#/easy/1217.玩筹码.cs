/*
 * @lc app=leetcode.cn id=1217 lang=csharp
 *
 * [1217] 玩筹码
 */

// @lc code=start
public class Solution
{
    public int MinCostToMoveChips(int[] position)
    {
        int even = 0, odd = 0;
        foreach (int pos in position)
        {
            if ((pos & 1) != 0)
            {
                odd++;
            }
            else
            {
                even++;
            }
        }
        return Math.Min(odd, even);
    }
}
// @lc code=end

