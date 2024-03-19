/*
 * @lc app=leetcode.cn id=2164 lang=csharp
 * @lcpr version=30119
 *
 * [2164] 对奇偶下标分别排序
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] SortEvenOdd(int[] nums)
    {
        var evens = nums.Where((x, i) => i % 2 == 0).ToList();
        var odds = nums.Where((x, i) => i % 2 != 0).ToList();

        evens.Sort();
        odds.Sort((x, y) => -x.CompareTo(y));

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                nums[i] = evens[i / 2];
            }
            else
            {
                nums[i] = odds[i / 2];
            }
        }

        return nums;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,1,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [2,1]\n
// @lcpr case=end

 */

