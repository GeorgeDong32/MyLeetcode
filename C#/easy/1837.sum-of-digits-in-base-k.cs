/*
 * @lc app=leetcode.cn id=1837 lang=csharp
 * @lcpr version=30117
 *
 * [1837] K 进制表示下的各位数字总和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SumBase(int n, int k)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % k;
            n /= k;
        }
        return sum;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 34\n6\n
// @lcpr case=end

// @lcpr case=start
// 10\n10\n
// @lcpr case=end

 */

