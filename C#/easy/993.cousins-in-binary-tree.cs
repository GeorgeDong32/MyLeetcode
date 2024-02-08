/*
 * @lc app=leetcode.cn id=993 lang=csharp
 * @lcpr version=30116
 *
 * [993] 二叉树的堂兄弟节点
 */


// @lcpr-template-start

// @lcpr-template-end

/*
 * Definition for a binary tree node.
 */
public class TreeNode
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
}
// @lc code=start
public class Solution
{
    TreeNode xParent, yParent;
    int xDepth, yDepth;
    public bool IsCousins(TreeNode root, int x, int y)
    {
        DFS(root, null, x, y, 0);
        return xDepth == yDepth && xParent != yParent;
    }

    public void DFS(TreeNode root, TreeNode parent, int x, int y, int depth)
    {
        if (root == null) return;
        if (root.val == x)
        {
            xParent = parent;
            xDepth = depth;
        }
        else if (root.val == y)
        {
            yParent = parent;
            yDepth = depth;
        }
        DFS(root.left, root, x, y, depth + 1);
        DFS(root.right, root, x, y, depth + 1);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4]\n4\n3\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,null,4,null,5]\n5\n4\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,null,4]\n2\n3\n
// @lcpr case=end

 */

