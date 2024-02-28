/*
 * @lc app=leetcode.cn id=1854 lang=csharp
 * @lcpr version=30117
 *
 * [1854] 人口最多的年份
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaximumPopulation(int[][] logs)
    {
        var population = new int[101];
        foreach (var log in logs)
        {
            for (int i = log[0]; i < log[1]; i++)
            {
                population[i - 1950]++;
            }
        }
        var maxpop = population.Max();
        return Array.IndexOf(population, maxpop) + 1950;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1993,1999],[2000,2010]]\n
// @lcpr case=end

// @lcpr case=start
// [[1950,1961],[1960,1971],[1970,1981]]\n
// @lcpr case=end

 */

