/*
 * @lc app=leetcode.cn id=2006 lang=csharp
 * @lcpr version=30118
 *
 * [2006] 差的绝对值为 K 的数对数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountKDifference(int[] nums, int k)
    {
        return nums.SelectMany((num1, index1) => nums.Where((num2, index2) => index2 > index1 && Math.Abs(num1 - num2) == k)).Count();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,2,1]\n1\n
// @lcpr case=end

// @lcpr case=start
// [1,3]\n3\n
// @lcpr case=end

// @lcpr case=start
// [3,2,1,5,4]\n2\n
// @lcpr case=end

 */

