/*
 * @lc app=leetcode.cn id=2215 lang=csharp
 * @lcpr version=30122
 *
 * [2215] 找出两数组的不同
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var dict1 = new HashSet<int>(nums1);
        var dict2 = new HashSet<int>(nums2);
        var ans = new List<IList<int>>();
        var a0 = new HashSet<int>();
        var a1 = new HashSet<int>();
        foreach (var n in nums1)
        {
            if (!dict2.Contains(n))
                a0.Add(n);
        }
        foreach (var n in nums2)
        {
            if (!dict1.Contains(n))
                a1.Add(n);
        }
        ans.Add(a0.ToList());
        ans.Add(a1.ToList());
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n[2,4,6]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,3]\n[1,1,2,2]\n
// @lcpr case=end

 */

