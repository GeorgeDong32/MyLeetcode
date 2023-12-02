/*
 * @lc app=leetcode.cn id=830 lang=csharp
 *
 * [830] 较大分组的位置
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> LargeGroupPositions(string s)
    {
        var ans = new List<IList<int>>();
        int index = 0;
        while (index < s.Length)
        {
            int start = index;
            while (index < s.Length && s[index] == s[start]) index++;
            if (index - start >= 3)
                ans.Add((new int[] { start, index - 1 }).ToList());
        }
        return ans;
    }
}
// @lc code=end

