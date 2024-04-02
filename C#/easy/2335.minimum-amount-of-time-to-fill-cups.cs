/*
 * @lc app=leetcode.cn id=2335 lang=csharp
 * @lcpr version=30121
 *
 * [2335] 装满杯子需要的最短总时长
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FillCups(int[] amount)
    {
        Array.Sort(amount);
        if (amount[2] > amount[1] + amount[0])
        {
            return amount[2];
        }
        return (amount[0] + amount[1] + amount[2] + 1) / 2;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,4,2]\n
// @lcpr case=end

// @lcpr case=start
// [5,4,4]\n
// @lcpr case=end

// @lcpr case=start
// [5,0,0]\n
// @lcpr case=end

 */

