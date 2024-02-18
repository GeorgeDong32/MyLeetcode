/*
 * @lc app=leetcode.cn id=429 lang=csharp
 * @lcpr version=30116
 *
 * [429] N 叉树的层序遍历
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
    public IList<IList<int>> LevelOrder(Node root)
    {
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }

        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var level = new List<int>();
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                level.Add(node.val);

                foreach (var child in node.children)
                {
                    queue.Enqueue(child);
                }
            }

            result.Add(level);
        }

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

