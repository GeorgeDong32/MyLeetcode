/*
 * @lc app=leetcode.cn id=11 lang=csharp
 * @lcpr version=30122
 *
 * [11] 盛最多水的容器
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxArea(int[] height)
    {
        var l = 0; var r = height.Length - 1;
        var max = 0; var temp = 0;
        while (l < r)
        {
            temp = (r - l) * Math.Min(height[l], height[r]);
            max = Math.Max(max, temp);
            if (height[l] >= height[r])
                r--;
            else
                l++;
        }
        return max;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,8,6,2,5,4,8,3,7]\n
// @lcpr case=end

// @lcpr case=start
// [1,1]\n
// @lcpr case=end

 */

