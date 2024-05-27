/*
 * @lc app=leetcode.cn id=2028 lang=csharp
 * @lcpr version=30202
 *
 * [2028] 找出缺失的观测数据
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        var len = rolls.Length;
        var diff = mean * (n + len) - rolls.Sum();
        if (diff > n * 6 || diff < n)
            return [];
        var ans = new int[n];
        var avg = diff / n; var remains = diff % n;
        for (var i = 0; i < n; i++)
        {
            ans[i] = avg;
            if (remains > 0)
            {
                ans[i]++;
                remains--;
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,4,3]\n4\n2\n
// @lcpr case=end

// @lcpr case=start
// [1,5,6]\n3\n4\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4]\n6\n4\n
// @lcpr case=end

// @lcpr case=start
// [1]\n3\n1\n
// @lcpr case=end

 */

