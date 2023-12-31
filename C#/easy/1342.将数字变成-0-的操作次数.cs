/*
 * @lc app=leetcode.cn id=1342 lang=csharp
 *
 * [1342] 将数字变成 0 的操作次数
 */

// @lc code=start
public class Solution
{
    public int NumberOfSteps(int num)
    {
        var count = 0;
        while (num != 0)
        {
            if (num % 2 == 0)
                num /= 2;
            else
                num -= 1;
            count++;
        }
        return count;
    }
}
// @lc code=end

