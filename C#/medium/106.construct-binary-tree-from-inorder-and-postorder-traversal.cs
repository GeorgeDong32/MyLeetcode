/*
 * @lc app=leetcode.cn id=106 lang=csharp
 * @lcpr version=30117
 *
 * [106] 从中序与后序遍历序列构造二叉树
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
    int postIndex;
    Dictionary<int, int> inorderIndexMap;
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        postIndex = postorder.Length - 1;
        // build a hashmap to store value -> its index relations
        inorderIndexMap = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++)
        {
            inorderIndexMap.Add(inorder[i], i);
        }
        return BuildTreeHelper(inorder, postorder, 0, inorder.Length - 1);
    }

    private TreeNode BuildTreeHelper(int[] inorder, int[] postorder, int left, int right)
    {
        if (left > right)
        {
            return null;
        }
        int rootValue = postorder[postIndex];
        TreeNode root = new TreeNode(rootValue);
        int index = inorderIndexMap[rootValue];
        // recursion 
        postIndex--;
        // build right subtree
        root.right = BuildTreeHelper(inorder, postorder, index + 1, right);
        // build left subtree
        root.left = BuildTreeHelper(inorder, postorder, left, index - 1);
        return root;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [9,3,15,20,7]\n[9,15,7,20,3]\n
// @lcpr case=end

// @lcpr case=start
// [-1]\n[-1]\n
// @lcpr case=end

 */

