/*
 * @lc app=leetcode.cn id=2169 lang=csharp
 * @lcpr version=30119
 *
 * [2169] 得到 0 的操作数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountOperations(int num1, int num2)
    {
        var count = 0;
        while (!(num1 == 0 || num2 == 0))
        {
            switch (num1 >= num2)
            {
                case true:
                    num1 -= num2;
                    break;
                case false:
                    num2 -= num1;
                    break;
            }
            count++;
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n3\n
// @lcpr case=end

// @lcpr case=start
// 10\n10\n
// @lcpr case=end

 */

