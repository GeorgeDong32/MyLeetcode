/*
 * @lc app=leetcode.cn id=429 lang=csharp
 * @lcpr version=30201
 *
 * [429] N 叉树的层序遍历
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start

// Definition for a Node.
// public class Node
// {
//     public int val;
//     public IList<Node> children;

//     public Node() { }

//     public Node(int _val)
//     {
//         val = _val;
//     }

//     public Node(int _val, IList<Node> _children)
//     {
//         val = _val;
//         children = _children;
//     }
// }


public class Solution
{
    public IList<IList<int>> LevelOrder(Node root)
    {
        var q = new Queue<Node>();
        var ans = new List<IList<int>>();
        if (root != null)
            q.Enqueue(root);
        while (q.Count > 0)
        {
            var list = new List<int>();
            var size = q.Count;
            while (size > 0)
            {
                var temp = q.Dequeue();
                list.Add(temp.val);
                foreach (var child in temp.children)
                {
                    if (child != null)
                        q.Enqueue(child);
                }
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
// [1,null,3,2,4,null,5,6]\n
// @lcpr case=end

// @lcpr case=start
// [1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]\n
// @lcpr case=end

 */

