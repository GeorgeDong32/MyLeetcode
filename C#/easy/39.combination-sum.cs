/*
 * @lc app=leetcode.cn id=39 lang=csharp
 * @lcpr version=30122
 *
 * [39] 组合总和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    private IList<IList<int>> combinations = [];
    private IList<int> temp = [];
    private int[]? candidates;
    private int n;

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        this.candidates = candidates;
        this.n = candidates.Length;
        Backtrack(0, target);
        return combinations;
    }

    public void Backtrack(int index, int remain)
    {
        if (remain == 0)
        {
            combinations.Add(new List<int>(temp));
        }
        else
        {
            for (int i = index; i < n && candidates[i] <= remain; i++)
            {
                temp.Add(candidates[i]);
                Backtrack(i, remain - candidates[i]);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,6,7]\n7\n
// @lcpr case=end

// @lcpr case=start
// [2,3,5]\n8\n
// @lcpr case=end

// @lcpr case=start
// [2]\n1\n
// @lcpr case=end

 */

