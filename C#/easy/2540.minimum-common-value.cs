/*
 * @lc app=leetcode.cn id=2540 lang=csharp
 * @lcpr version=30121
 *
 * [2540] 最小公共值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>(nums1);
        var nn2 = nums2.Distinct().ToArray();
        foreach (var n in nn2)
        {
            if (!set.Add(n))
                return n;
        }
        return -1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n[2,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,6]\n[2,3,4,5]\n
// @lcpr case=end

 */

