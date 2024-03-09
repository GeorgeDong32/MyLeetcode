/*
 * @lc app=leetcode.cn id=2078 lang=csharp
 * @lcpr version=30118
 *
 * [2078] 两栋颜色不同且距离最远的房子
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxDistance(int[] colors)
    {
        int n = colors.Length;
        if (colors[0] != colors[n - 1])
        {
            return n - 1;
        }
        int color = colors[0];
        int left = 1, right = n - 2;
        while (colors[left] == color)
        {
            left++;
        }
        while (colors[right] == color)
        {
            right--;
        }
        return Math.Max(right, n - 1 - left);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,1,6,1,1,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,8,3,8,3]\n
// @lcpr case=end

// @lcpr case=start
// [0,1]\n
// @lcpr case=end

 */

