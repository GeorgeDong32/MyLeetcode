/*
@lc app=leetcode.cn id=872 lang=csharp
@lcpr version=30122
 *
[872] 叶子相似的树
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start

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

public class Solution
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var leaf1 = new List<int>();
        var leaf2 = new List<int>();
        if (root1 != null)
            DFS(root1, leaf1);
        if (root2 != null)
            DFS(root2, leaf2);
        return leaf1.SequenceEqual(leaf2);
    }

    private void DFS(TreeNode root, IList<int> leafs)
    {
        if (root.left == null && root.right == null)
        {
            leafs.Add(root.val);
            return;
        }
        else
        {
            if (root.left != null)
            {
                DFS(root.left, leafs);
            }
            if (root.right != null)
            {
                DFS(root.right, leafs);
            }
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,5,1,6,2,9,8,null,null,7,4]\n[3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n[1,3,2]\n
// @lcpr case=end

 */

