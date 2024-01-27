/*
 * @lc app=leetcode.cn id=1550 lang=csharp
 *
 * [1550] 存在连续三个奇数的数组
 */

// @lc code=start
public class Solution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        int count = 0;
        foreach (var num in arr)
        {
            if (num % 2 == 1)
            {
                count++;
                if (count >= 3)
                {
                    return true;
                }
            }
            else
            {
                count = 0;
            }
        }
        return false;
    }
}
// @lc code=end

