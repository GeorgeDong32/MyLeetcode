/*
 * @lc app=leetcode.cn id=1995 lang=csharp
 * @lcpr version=30118
 *
 * [1995] 统计特殊四元组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountQuadruplets(int[] nums)
    {
        int n = nums.Length;
        int ans = 0;
        Dictionary<int, int> cnt = new Dictionary<int, int>();
        for (int b = n - 3; b >= 1; --b)
        {
            for (int d = b + 2; d < n; ++d)
            {
                int difference = nums[d] - nums[b + 1];
                if (!cnt.TryAdd(difference, 1))
                {
                    ++cnt[difference];
                }
            }
            for (int a = 0; a < b; ++a)
            {
                int sum = nums[a] + nums[b];
                if (cnt.ContainsKey(sum))
                {
                    ans += cnt[sum];
                }
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,6]\n
// @lcpr case=end

// @lcpr case=start
// [3,3,6,4,5]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,3,5]\n
// @lcpr case=end

 */

