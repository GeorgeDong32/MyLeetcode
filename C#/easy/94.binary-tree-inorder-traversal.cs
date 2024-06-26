/*
 * @lc app=leetcode.cn id=94 lang=csharp
 * @lcpr version=30201
 *
 * [94] 二叉树的中序遍历
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
// public class TreeNode
// {
//     public int val;
//     public TreeNode? left;
//     public TreeNode? right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var ans = new List<int>();
        Traversal(root, ans);
        return ans;
    }

    public void Traversal(TreeNode root, IList<int> res)
    {
        if (root == null)
            return;
        Traversal(root.left, res);
        res.Add(root.val);
        Traversal(root.right, res);
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

 */

