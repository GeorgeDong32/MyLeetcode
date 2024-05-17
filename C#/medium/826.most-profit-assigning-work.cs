/*
 * @lc app=leetcode.cn id=826 lang=csharp
 * @lcpr version=30202
 *
 * [826] 安排工作以达到最大收益
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        var jobs = new (int diff, int prof)[difficulty.Length];
        for (int i = 0; i < difficulty.Length; i++)
        {
            jobs[i] = (difficulty[i], profit[i]);
        }
        Array.Sort(jobs, (a, b) => a.diff.CompareTo(b.diff));
        int[] maxProfit = new int[difficulty.Length];
        maxProfit[0] = jobs[0].prof;
        for (int i = 1; i < difficulty.Length; i++)
        {
            maxProfit[i] = Math.Max(maxProfit[i - 1], jobs[i].prof);
        }
        Array.Sort(worker);
        int totalProfit = 0, jobIndex = 0;
        for (int i = 0; i < worker.Length; i++)
        {
            while (jobIndex < jobs.Length && worker[i] >= jobs[jobIndex].diff)
            {
                jobIndex++;
            }
            if (jobIndex > 0)
            {
                totalProfit += maxProfit[jobIndex - 1];
            }
        }
        return totalProfit;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,4,6,8,10]\n[10,20,30,40,50]\n[4,5,6,7]\n
// @lcpr case=end

// @lcpr case=start
// [85,47,57]\n[24,66,99]\n[40,25,25]\n
// @lcpr case=end

 */

