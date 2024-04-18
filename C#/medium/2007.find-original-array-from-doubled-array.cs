/*
 * @lc app=leetcode.cn id=2007 lang=csharp
 * @lcpr version=30122
 *
 * [2007] 从双倍数组中还原原数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] FindOriginalArray(int[] changed)
    {
        Array.Sort(changed);
        var count = new Dictionary<int, int>();
        foreach (var a in changed)
        {
            count.TryAdd(a, 0);
            count[a]++;
        }
        var res = new int[changed.Length / 2];
        int i = 0;
        foreach (var a in changed)
        {
            if (count[a] == 0)
            {
                continue;
            }
            count[a]--;
            if (!count.ContainsKey(a * 2) || count[a * 2] == 0)
            {
                return [];
            }
            count[a * 2]--;
            res[i++] = a;
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,4,2,6,8]\n
// @lcpr case=end

// @lcpr case=start
// [6,3,0,1]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

