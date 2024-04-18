/*
 * @lc app=leetcode.cn id=1137 lang=csharp
 * @lcpr version=30122
 *
 * [1137] 第 N 个泰波那契数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int Tribonacci(int n)
    {
        var rolls = new int[3];
        rolls[0] = 0; rolls[1] = 1; rolls[2] = 1;
        if (n < 3)
            return rolls[n];
        n -= 2;
        while (n > 0)
        {
            var temp = rolls[0];
            rolls[0] = rolls[1];
            rolls[1] = rolls[2];
            rolls[2] = temp + rolls[0] + rolls[1];
            n--;
        }
        return rolls[2];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 4\n
// @lcpr case=end

// @lcpr case=start
// 25\n
// @lcpr case=end

 */

