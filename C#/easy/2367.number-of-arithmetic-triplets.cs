/*
 * @lc app=leetcode.cn id=2367 lang=csharp
 * @lcpr version=30121
 *
 * [2367] 算术三元组的数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int ArithmeticTriplets(int[] nums, int diff)
    {
        int triplets = 0;
        ISet<int> set = new HashSet<int>();
        foreach (int num in nums)
        {
            set.Add(num);
            if (set.Contains(num - diff) && set.Contains(num - 2 * diff))
            {
                triplets++;
            }
        }
        return triplets;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [0,1,4,6,7,10]\n3\n
// @lcpr case=end

// @lcpr case=start
// [4,5,6,7,8,9]\n2\n
// @lcpr case=end

 */

