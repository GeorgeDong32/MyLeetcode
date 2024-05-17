/*
 * @lc app=leetcode.cn id=77 lang=csharp
 * @lcpr version=30202
 *
 * [77] 组合
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    private List<IList<int>> ans = new();
    private Stack<int> temp = new();

    public IList<IList<int>> Combine(int n, int k)
    {
        ans.Clear();
        temp.Clear();
        BackTrace(n, k, 1);
        return ans;
    }

    public void BackTrace(int n, int k, int startIndex)
    {
        if (temp.Count == k)
        {
            ans.Add(temp.ToList());
            return;
        }
        for (var i = startIndex; i <= n; i++)
        {
            temp.Push(i);
            BackTrace(n, k, i + 1);
            temp.Pop();
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// 4\n2\n
// @lcpr case=end

// @lcpr case=start
// 1\n1\n
// @lcpr case=end

 */

