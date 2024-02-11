/*
 * @lc app=leetcode.cn id=1732 lang=csharp
 * @lcpr version=30116
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
        var alt = new int[gain.Length + 1];
        for (var i = 0; i < gain.Length; i++)
        {
            alt[i + 1] = alt[i] + gain[i];
        }
        return alt.Max();
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

