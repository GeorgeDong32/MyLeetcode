/*
 * @lc app=leetcode.cn id=2485 lang=csharp
 * @lcpr version=30121
 *
 * [2485] 找出中枢整数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int PivotInteger(int n)
    {
        int pivot = -1;
        for (int x = 1; x <= n && pivot < 0; x++)
        {
            int leftSum = 0, rightSum = 0;
            for (int i = 1; i <= x; i++)
            {
                leftSum += i;
            }
            for (int i = x; i <= n; i++)
            {
                rightSum += i;
            }
            if (leftSum == rightSum)
            {
                pivot = x;
            }
        }
        return pivot;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 8\n
// @lcpr case=end

// @lcpr case=start
// 1\n
// @lcpr case=end

// @lcpr case=start
// 4\n
// @lcpr case=end

 */

