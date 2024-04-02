/*
 * @lc app=leetcode.cn id=2404 lang=csharp
 * @lcpr version=30121
 *
 * [2404] 出现最频繁的偶数元素
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MostFrequentEven(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            dict.TryAdd(n, 0);
            dict[n]++;
        }
        var evens = dict.Where(kv => kv.Key % 2 == 0).ToList();

        if (evens.Count == 0)
        {
            return -1;
        }

        return evens.Aggregate((a, b) => a.Value > b.Value || (a.Value == b.Value && a.Key < b.Key) ? a : b).Key;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [0,1,2,2,4,4,1]\n
// @lcpr case=end

// @lcpr case=start
// [4,4,4,9,2,4]\n
// @lcpr case=end

// @lcpr case=start
// [29,47,21,41,13,37,25,7]\n
// @lcpr case=end

 */

