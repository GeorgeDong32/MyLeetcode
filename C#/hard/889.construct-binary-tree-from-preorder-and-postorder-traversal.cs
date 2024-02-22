/*
 * @lc app=leetcode.cn id=889 lang=csharp
 * @lcpr version=30117
 *
 * [889] 根据前序和后序遍历构造二叉树
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
    int preIndex = 0, posIndex = 0;

    public TreeNode ConstructFromPrePost(int[] pre, int[] post)
    {
        TreeNode root = new TreeNode(pre[preIndex++]);
        if (root.val != post[posIndex])
            root.left = ConstructFromPrePost(pre, post);
        if (root.val != post[posIndex])
            root.right = ConstructFromPrePost(pre, post);
        posIndex++;
        return root;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,4,5,3,6,7]\n[4,5,2,6,7,3,1]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n[1]\n
// @lcpr case=end

 */

