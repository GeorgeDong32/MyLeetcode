/*
 * @lc app=leetcode.cn id=938 lang=csharp
 * @lcpr version=30117
 *
 * [938] 二叉搜索树的范围和
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
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null) return 0;
        if (root.val < low) return RangeSumBST(root.right, low, high);
        if (root.val > high) return RangeSumBST(root.left, low, high);
        return root.val + RangeSumBST(root.right, low, high) + RangeSumBST(root.left, low, high);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [10,5,15,3,7,null,18]\n7\n15\n
// @lcpr case=end

// @lcpr case=start
// [10,5,15,3,7,13,18,1,null,6]\n6\n10\n
// @lcpr case=end

 */

