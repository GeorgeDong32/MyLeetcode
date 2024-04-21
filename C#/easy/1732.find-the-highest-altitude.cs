/*
 * @lc app=leetcode.cn id=1732 lang=csharp
 * @lcpr version=30122
 *
 * [1732] 找到最高海拔
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        var l = gain.Length;
        var prefix = new int[l + 1];
        prefix[0] = 0;
        for (var i = 0; i < l; i++)
        {
            prefix[i + 1] = prefix[i] + gain[i];
        }
        return prefix.Max();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [-5,1,5,0,-7]\n
// @lcpr case=end

// @lcpr case=start
// [-4,-3,-2,-1,4,3,2]\n
// @lcpr case=end

 */

