/*
 * @lc app=leetcode.cn id=590 lang=csharp
 * @lcpr version=30116
 *
 * [590] N 叉树的后序遍历
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution
{
    private List<int> result = new List<int>();

    public IList<int> Postorder(Node root)
    {
        if (root == null)
        {
            return result;
        }

        foreach (Node child in root.children)
        {
            Postorder(child);
        }
        result.Add(root.val);

        return result;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,null,3,2,4,null,5,6]\n
// @lcpr case=end

// @lcpr case=start
// [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]\n
// @lcpr case=end

 */

