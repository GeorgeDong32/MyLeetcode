/*
 * @lc app=leetcode.cn id=2441 lang=csharp
 * @lcpr version=30121
 *
 * [2441] 与对应负数同时存在的最大正整数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindMaxK(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int maxK = -1;
        foreach (var num in set)
        {
            if (num > 0 && set.Contains(-num))
            {
                maxK = Math.Max(maxK, num);
            }
        }
        return maxK;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [-1,2,-3,3]\n
// @lcpr case=end

// @lcpr case=start
// [-1,10,6,7,-7,1]\n
// @lcpr case=end

// @lcpr case=start
// [-10,8,6,7,-2,-3]\n
// @lcpr case=end

 */

