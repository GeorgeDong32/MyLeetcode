/*
 * @lc app=leetcode.cn id=102 lang=csharp
 * @lcpr version=30201
 *
 * [102] 二叉树的层序遍历
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        var ans = new List<IList<int>>();
        if (root != null)
            q.Enqueue(root);
        while (!(q.Count == 0))
        {
            var list = new List<int>();
            var size = q.Count;
            while (size > 0)
            {
                var cur = q.Dequeue();
                list.Add(cur.val);
                if (cur.left != null)
                    q.Enqueue(cur.left);
                if (cur.right != null)
                    q.Enqueue(cur.right);
                size--;
            }
            ans.Add(list);
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,9,20,null,null,15,7]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

 */

