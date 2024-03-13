/*
 * @lc app=leetcode.cn id=1261 lang=csharp
 * @lcpr version=30119
 *
 * [1261] 在受污染的二叉树中查找元素
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
public class FindElements
{
    ISet<int> values;

    public FindElements(TreeNode root)
    {
        values = new HashSet<int>();
        root.val = 0;
        DFS(root);
    }

    public bool Find(int target)
    {
        return values.Contains(target);
    }

    private void DFS(TreeNode node)
    {
        int value = node.val;
        values.Add(value);
        TreeNode left = node.left, right = node.right;
        if (left != null)
        {
            left.val = 2 * value + 1;
            DFS(left);
        }
        if (right != null)
        {
            right.val = 2 * value + 2;
            DFS(right);
        }
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */
// @lc code=end



/*
// @lcpr case=start
// ["FindElements","find","find"][[[-1,null,-1]],[1],[2]]\n
// @lcpr case=end

// @lcpr case=start
// ["FindElements","find","find","find"][[[-1,-1,-1,-1,-1]],[1],[3],[5]]\n
// @lcpr case=end

// @lcpr case=start
// ["FindElements","find","find","find","find"][[[-1,null,-1,-1,null,-1]],[2],[3],[4],[5]]\n
// @lcpr case=end

 */

