/*
 * @lc app=leetcode.cn id=987 lang=csharp
 * @lcpr version=30116
 *
 * [987] 二叉树的垂序遍历
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
    Dictionary<int, List<(int row, int val)>> columnTable = new Dictionary<int, List<(int row, int val)>>();
    int minColumn = 0, maxColumn = 0;

    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        DFS(root, 0, 0);
        List<IList<int>> output = new List<IList<int>>();
        for (int i = minColumn; i < maxColumn + 1; ++i)
        {
            columnTable[i].Sort((t1, t2) => t1.row == t2.row ? t1.val.CompareTo(t2.val) : t1.row.CompareTo(t2.row));
            List<int> sortedColumn = new List<int>();
            foreach (var p in columnTable[i])
            {
                sortedColumn.Add(p.val);
            }
            output.Add(sortedColumn);
        }
        return output;
    }

    private void DFS(TreeNode node, int row, int column)
    {
        if (node == null)
            return;
        if (!columnTable.ContainsKey(column))
        {
            columnTable[column] = new List<(int row, int val)>();
        }
        columnTable[column].Add((row, node.val));
        minColumn = Math.Min(minColumn, column);
        maxColumn = Math.Max(maxColumn, column);
        // preorder DFS traversal
        DFS(node.left, row + 1, column - 1);
        DFS(node.right, row + 1, column + 1);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,9,20,null,null,15,7]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,5,6,7]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,6,5,7]\n
// @lcpr case=end

 */

