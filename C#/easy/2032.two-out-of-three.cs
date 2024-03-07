/*
 * @lc app=leetcode.cn id=2032 lang=csharp
 * @lcpr version=30118
 *
 * [2032] 至少在两个数组中出现的值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        NumsCount(ref counts, nums1);
        NumsCount(ref counts, nums2);
        NumsCount(ref counts, nums3);
        return counts.Where(kv => kv.Value >= 2).Select(kv => kv.Key).ToList();
    }

    private static void NumsCount(ref Dictionary<int, int> count, int[] nums)
    {
        nums = nums.Distinct().ToArray();
        foreach (var n in nums)
        {
            if (!count.TryAdd(n, 1))
            {
                count[n]++;
            }
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,3,2]\n[2,3]\n[3]\n
// @lcpr case=end

// @lcpr case=start
// [3,1]\n[2,3]\n[1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,2]\n[4,3,3]\n[5]\n
// @lcpr case=end

 */

