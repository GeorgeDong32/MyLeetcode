/*
 * @lc app=leetcode.cn id=637 lang=csharp
 * @lcpr version=30201
 *
 * [637] 二叉树的层平均值
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
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        var ans = new List<double>();
        if (root != null)
            q.Enqueue(root);
        while (q.Count > 0)
        {
            var size = q.Count;
            var rosize = q.Count;
            long sum = 0;
            while (size > 0)
            {
                var temp = q.Dequeue();
                if (temp.left != null)
                    q.Enqueue(temp.left);
                if (temp.right != null)
                    q.Enqueue(temp.right);
                sum += temp.val;
                size--;
            }
            ans.Add((double)sum / rosize);
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,9,20,null,null,15,7]\n
// @lcpr case=end

// @lcpr case=start
// [3,9,20,15,7]\n
// @lcpr case=end

 */

