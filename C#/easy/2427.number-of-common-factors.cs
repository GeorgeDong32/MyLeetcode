/*
 * @lc app=leetcode.cn id=2427 lang=csharp
 * @lcpr version=30121
 *
 * [2427] 公因子的数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CommonFactors(int a, int b)
    {
        var count = 0;
        var maxCommonFactor = GCD(a, b);
        for (int i = 1; i * i <= maxCommonFactor; i++)
        {
            if (maxCommonFactor % i == 0)
            {
                count++;
                if (i * i < maxCommonFactor)
                {
                    count++;
                }
            }
        }
        return count;
    }

    public int GCD(int num1, int num2)
    {
        while (num2 != 0)
        {
            var temp = num1;
            num1 = num2;
            num2 = temp % num2;
        }
        return num1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 12\n6\n
// @lcpr case=end

// @lcpr case=start
// 25\n30\n
// @lcpr case=end

 */

