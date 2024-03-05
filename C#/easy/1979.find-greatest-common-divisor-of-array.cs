/*
 * @lc app=leetcode.cn id=1979 lang=csharp
 * @lcpr version=30118
 *
 * [1979] 找出数组的最大公约数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindGCD(int[] nums)
    {
        var min = nums.Min();
        var max = nums.Max();
        return GCD(min, max);
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,5,6,9,10]\n
// @lcpr case=end

// @lcpr case=start
// [7,5,6,8,3]\n
// @lcpr case=end

// @lcpr case=start
// [3,3]\n
// @lcpr case=end

 */

