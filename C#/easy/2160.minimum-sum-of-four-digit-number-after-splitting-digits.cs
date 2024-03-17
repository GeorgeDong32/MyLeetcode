/*
 * @lc app=leetcode.cn id=2160 lang=csharp
 * @lcpr version=30119
 *
 * [2160] 拆分数位后四位数字的最小和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumSum(int num)
    {
        var digits = new int[4];
        var count = 0;
        while (num > 0)
        {
            digits[count] = num % 10;
            num /= 10;
            count++;
        }
        Array.Sort(digits);
        return digits[0] * 10 + digits[2] + digits[1] * 10 + digits[3];
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2932\n
// @lcpr case=end

// @lcpr case=start
// 4009\n
// @lcpr case=end

 */

