/*
 * @lc app=leetcode.cn id=2535 lang=csharp
 * @lcpr version=30121
 *
 * [2535] 数组元素和与数字和的绝对差
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int DifferenceOfSum(int[] nums)
    {
        var sum = 0;
        var esum = 0;
        foreach (var x in nums)
        {
            sum += x;
            esum += DigitSum(x);
        }
        return Math.Abs(sum - esum);
    }

    private int DigitSum(int num)
    {
        var sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,15,6,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4]\n
// @lcpr case=end

 */

