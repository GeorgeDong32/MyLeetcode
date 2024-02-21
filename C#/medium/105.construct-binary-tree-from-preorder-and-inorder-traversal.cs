/*
 * @lc app=leetcode.cn id=105 lang=csharp
 * @lcpr version=30116
 *
 * [105] 从前序与中序遍历序列构造二叉树
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
    private int preIndex = 0;
    private Dictionary<int, int> inOrderIndexMap;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        inOrderIndexMap = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++)
        {
            inOrderIndexMap[inorder[i]] = i;
        }
        return BuildTreeHelper(preorder, 0, inorder.Length - 1);
    }

    private TreeNode BuildTreeHelper(int[] preorder, int inStart, int inEnd)
    {
        if (inStart > inEnd)
        {
            return null;
        }
        TreeNode root = new TreeNode(preorder[preIndex]);
        int inIndex = inOrderIndexMap[preorder[preIndex]];
        preIndex++;
        root.left = BuildTreeHelper(preorder, inStart, inIndex - 1);
        root.right = BuildTreeHelper(preorder, inIndex + 1, inEnd);
        return root;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,9,20,15,7]\n[9,3,15,20,7]\n
// @lcpr case=end

// @lcpr case=start
// [-1]\n[-1]\n
// @lcpr case=end

 */

