/*
 * @lc app=leetcode.cn id=144 lang=csharp
 * @lcpr version=30116
 *
 * [144] 二叉树的前序遍历
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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        Preorder(root, result);
        return result;
    }

    private void Preorder(TreeNode node, List<int> result)
    {
        if (node != null)
        {
            result.Add(node.val);
            Preorder(node.left, result);
            Preorder(node.right, result);
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,null,2,3]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,null,2]\n
// @lcpr case=end

 */

