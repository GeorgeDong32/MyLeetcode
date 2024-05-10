/*
@lc app=leetcode.cn id=LCR 046 lang=csharp
@lcpr version=30201
 *
[LCR 046] 二叉树的右视图
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start

// public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
// {
//     public int val = val;
//     public TreeNode left = left;
//     public TreeNode right = right;
// }

public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        var ans = new List<int>();
        if (root != null)
            q.Enqueue(root);
        while (q.Count > 0)
        {
            var size = q.Count;
            while (size > 0)
            {
                var temp = q.Dequeue();
                if (temp.left != null)
                    q.Enqueue(temp.left);
                if (temp.right != null)
                    q.Enqueue(temp.right);
                if (size == 1)
                    ans.Add(temp.val);
                size--;
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,null,5,null,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,null,3]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

 */

