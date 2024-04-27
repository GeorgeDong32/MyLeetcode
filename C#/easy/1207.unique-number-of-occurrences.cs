/*
 * @lc app=leetcode.cn id=1207 lang=csharp
 * @lcpr version=30122
 *
 * [1207] 独一无二的出现次数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var count = new Dictionary<int, int>();
        var cset = new HashSet<int>();
        foreach (var i in arr)
        {
            count.TryAdd(i, 0);
            count[i]++;
        }
        foreach (var kv in count)
        {
            cset.Add(kv.Value);
        }
        return cset.Count == count.Count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,2,1,1,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n
// @lcpr case=end

// @lcpr case=start
// [-3,0,1,-3,1,1,1,-3,10,0]\n
// @lcpr case=end

 */

