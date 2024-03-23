/*
 * @lc app=leetcode.cn id=2200 lang=csharp
 * @lcpr version=30119
 *
 * [2200] 找出数组中的所有 K 近邻下标
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var keyindex = nums.Select((value, index) => new { value, index })
                   .Where(pair => pair.value == key)
                   .Select(pair => pair.index);
        var ans = new HashSet<int>();
        foreach (var ki in keyindex)
        {
            for (var i = -k; i <= k; i++)
            {
                if (ki + i >= 0 && ki + i < nums.Length)
                {
                    ans.Add(ki + i);
                }
            }
        }
        return [.. ans];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,4,9,1,3,9,5]\n9\n1\n
// @lcpr case=end

// @lcpr case=start
// [2,2,2,2,2]\n2\n2\n
// @lcpr case=end

 */

