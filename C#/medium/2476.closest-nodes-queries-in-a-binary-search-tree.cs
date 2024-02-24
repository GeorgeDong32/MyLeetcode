/*
 * @lc app=leetcode.cn id=2476 lang=csharp
 * @lcpr version=30117
 *
 * [2476] 二叉搜索树最近节点查询
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
    IList<int> traversal = new List<int>();

    public IList<IList<int>> ClosestNodes(TreeNode root, IList<int> queries)
    {
        Inorder(root);
        int m = traversal.Count;
        IList<IList<int>> answer = new List<IList<int>>();
        foreach (int query in queries)
        {
            IList<int> values = new List<int>();
            int index = BinarySearch(traversal, query);
            if (index >= 0 && traversal[index] == query)
            {
                values.Add(query);
                values.Add(query);
            }
            else
            {
                values.Add(index >= 0 ? traversal[index] : -1);
                values.Add(index + 1 < m ? traversal[index + 1] : -1);
            }
            answer.Add(values);
        }
        return answer;
    }

    public void Inorder(TreeNode node)
    {
        if (node == null)
        {
            return;
        }
        Inorder(node.left);
        traversal.Add(node.val);
        Inorder(node.right);
    }

    public int BinarySearch(IList<int> traversal, int target)
    {
        int low = -1, high = traversal.Count - 1;
        while (low < high)
        {
            int mid = low + (high - low + 1) / 2;
            if (traversal[mid] <= target)
            {
                low = mid;
            }
            else
            {
                high = mid - 1;
            }
        }
        return low;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [6,2,13,1,4,9,15,null,null,null,null,null,null,14]\n[2,5,16]\n
// @lcpr case=end

// @lcpr case=start
// [4,null,9]\n[3]\n
// @lcpr case=end

 */

