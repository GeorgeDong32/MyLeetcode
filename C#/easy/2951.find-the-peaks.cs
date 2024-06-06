/*
 * @lc app=leetcode.cn id=2951 lang=csharp
 * @lcpr version=30202
 *
 * [2951] 找出峰值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<int> FindPeaks(int[] mountain)
    {
        var ans = new List<int>();
        for (var i = 1; i < mountain.Length - 1; i++)
        {
            if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
                ans.Add(i);
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,4,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,4,3,8,5]\n
// @lcpr case=end

 */

