/*
 * @lc app=leetcode.cn id=2644 lang=csharp
 * @lcpr version=30122
 *
 * [2644] 找出可整除性得分最大的整数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxDivScore(int[] nums, int[] divisors)
    {
        var maxgoal = 0; var best = divisors[0];
        foreach (var d in divisors)
        {
            var count = 0;
            foreach (var n in nums)
            {
                if (n % d == 0)
                    count++;
            }
            if (count > maxgoal)
            {
                maxgoal = count;
                best = d;
            }
            else if (count == maxgoal)
            {
                best = d < best ? d : best;
            }
        }
        return best;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,7,9,3,9]\n[5,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [20,14,21,10]\n[5,7,5]\n
// @lcpr case=end

// @lcpr case=start
// [12]\n[10,16]\n
// @lcpr case=end

 */

