/*
 * @lc app=leetcode.cn id=575 lang=csharp
 * @lcpr version=30203
 *
 * [575] 分糖果
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        ISet<int> set = new HashSet<int>();
        foreach (int candy in candyType)
        {
            set.Add(candy);
        }
        return Math.Min(set.Count, candyType.Length / 2);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,2,2,3,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [6,6,6,6]\n
// @lcpr case=end

 */

