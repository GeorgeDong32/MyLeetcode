/*
 * @lc app=leetcode.cn id=2641 lang=csharp
 * @lcpr version=30116
 *
 * [2641] 二叉树的堂兄弟节点 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public TreeNode ReplaceValueInTree(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        root.val = 0;
        while (queue.Count > 0)
        {
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            int sum = 0;
            foreach (TreeNode fa in queue)
            {
                if (fa.left != null)
                {
                    queue2.Enqueue(fa.left);
                    sum += fa.left.val;
                }
                if (fa.right != null)
                {
                    queue2.Enqueue(fa.right);
                    sum += fa.right.val;
                }
            }
            foreach (TreeNode fa in queue)
            {
                int childSum = (fa.left != null ? fa.left.val : 0) +
                                (fa.right != null ? fa.right.val : 0);
                if (fa.left != null)
                {
                    fa.left.val = sum - childSum;
                }
                if (fa.right != null)
                {
                    fa.right.val = sum - childSum;
                }
            }
            queue = queue2;
        }
        return root;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,4,9,1,10,null,7]\n
// @lcpr case=end

// @lcpr case=start
// [3,1,2]\n
// @lcpr case=end

 */

