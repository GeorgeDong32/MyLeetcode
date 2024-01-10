/*
 * @lc app=leetcode.cn id=2236 lang=csharp
 *
 * [2236] 判断根结点是否等于子结点之和
 */

// @lc code=start


/* public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
} */

public class Solution
{
    public bool CheckTree(TreeNode root)
    {
        return root.left.val + root.right.val == root.val;
    }
}
// @lc code=end

