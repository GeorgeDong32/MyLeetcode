/*
 * @lc app=leetcode.cn id=2583 lang=csharp
 * @lcpr version=30117
 *
 * [2583] 二叉树中的第 K 大层和
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
    public long KthLargestLevelSum(TreeNode root, int k)
    {
        if (root == null) return 0;
        List<long> sums = new List<long>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            long sum = 0;
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                TreeNode node = queue.Dequeue();
                sum += node.val;
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            sums.Add(sum);
        }
        sums.Sort((a, b) => b.CompareTo(a));
        if (k > sums.Count)
            return -1;
        return sums[k - 1];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,8,9,2,1,3,7,4,6]\n2\n
// @lcpr case=end

// @lcpr case=start
// [1,2,null,3]\n1\n
// @lcpr case=end

 */

