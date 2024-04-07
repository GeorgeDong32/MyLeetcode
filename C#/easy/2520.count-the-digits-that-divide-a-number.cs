/*
 * @lc app=leetcode.cn id=2520 lang=csharp
 * @lcpr version=30121
 *
 * [2520] 统计能整除数字的位数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountDigits(int num)
    {
        var temp = num;
        var count = 0;
        while (temp > 0)
        {
            var digit = temp % 10;
            if (digit != 0)
                if (num % digit == 0)
                    count++;
            temp /= 10;
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 7\n
// @lcpr case=end

// @lcpr case=start
// 121\n
// @lcpr case=end

// @lcpr case=start
// 1248\n
// @lcpr case=end

 */

