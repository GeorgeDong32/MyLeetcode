/*
 * @lc app=leetcode.cn id=144 lang=csharp
 * @lcpr version=30201
 *
 * [144] 二叉树的前序遍历
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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var ans = new List<int>();
        Traversal(root, ans);
        return ans;
    }

    public void Traversal(TreeNode root, IList<int> res)
    {
        if (root == null)
            return;
        res.Add(root.val);
        Traversal(root.left, res);
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

// @lcpr case=start
// [1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,null,2]\n
// @lcpr case=end

 */

