/*
 * @lc app=leetcode.cn id=2465 lang=csharp
 * @lcpr version=30121
 *
 * [2465] 不同的平均值数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int DistinctAverages(int[] nums)
    {
        var set = new HashSet<double>();
        Array.Sort(nums);
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            set.Add((double)((nums[left] + nums[right]) / (double)2));
            left++; right--;
        }
        return set.Count();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,1,4,0,3,5]\n
// @lcpr case=end

// @lcpr case=start
// [1,100]\n
// @lcpr case=end

 */

