/*
 * @lc app=leetcode.cn id=2057 lang=csharp
 * @lcpr version=30119
 *
 * [2057] 值相等的最小索引
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SmallestEqual(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == i % 10)
            {
                return i;
            }
        }
        return -1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [0,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [4,3,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,5,6,7,8,9,0]\n
// @lcpr case=end

// @lcpr case=start
// [2,1,3,5,2]\n
// @lcpr case=end

 */

