/*
 * @lc app=leetcode.cn id=515 lang=csharp
 * @lcpr version=30201
 *
 * [515] 在每个树行中找最大值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start

// public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
// {
//     public int val = val;
//     public TreeNode left = left;
//     public TreeNode right = right;
// }

public class Solution
{
    public IList<int> LargestValues(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        var ans = new List<int>();
        if (root != null)
            q.Enqueue(root);
        while (q.Count > 0)
        {
            var size = q.Count;
            var max = int.MinValue;
            while (size > 0)
            {
                var temp = q.Dequeue();
                if (temp.left != null)
                    q.Enqueue(temp.left);
                if (temp.right != null)
                    q.Enqueue(temp.right);
                max = Math.Max(max, temp.val);
                size--;
            }
            ans.Add(max);
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,2,5,3,null,9]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n
// @lcpr case=end

 */

