/*
 * @lc app=leetcode.cn id=605 lang=csharp
 * @lcpr version=30122
 *
 * [605] 种花问题
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;
        int m = flowerbed.Length;
        int prev = -2;
        for (int i = 0; i < m; i++)
        {
            if (flowerbed[i] == 1)
            {
                count += (i - prev - 2) / 2;
                if (count >= n)
                {
                    return true;
                }
                prev = i;
            }
        }
        count += (m - prev - 1) / 2;
        return count >= n;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,0,0,0,1]\n1\n
// @lcpr case=end

// @lcpr case=start
// [1,0,0,0,1]\n2\n
// @lcpr case=end

 */

