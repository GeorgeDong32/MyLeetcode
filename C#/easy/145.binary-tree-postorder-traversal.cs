/*
 * @lc app=leetcode.cn id=145 lang=csharp
 * @lcpr version=30201
 *
 * [145] 二叉树的后序遍历
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
    public IList<int> PostorderTraversal(TreeNode root)
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
        Traversal(root.right, res);
        res.Add(root.val);
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

