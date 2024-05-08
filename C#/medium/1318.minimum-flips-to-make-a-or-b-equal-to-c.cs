/*
 * @lc app=leetcode.cn id=1318 lang=csharp
 * @lcpr version=30122
 *
 * [1318] 或运算的最小翻转次数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinFlips(int a, int b, int c)
    {
        var flips = 0;
        while (a > 0 || b > 0 || c > 0)
        {
            int aBit = a & 1, bBit = b & 1, cBit = c & 1;
            if ((aBit | bBit) != cBit)
            {
                if (cBit == 1)
                {
                    flips++;
                }
                else
                {
                    flips += aBit + bBit;
                }
            }
            a >>= 1;
            b >>= 1;
            c >>= 1;
        }
        return flips;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n6\n5\n
// @lcpr case=end

// @lcpr case=start
// 4\n2\n7\n
// @lcpr case=end

// @lcpr case=start
// 1\n2\n3\n
// @lcpr case=end

 */

