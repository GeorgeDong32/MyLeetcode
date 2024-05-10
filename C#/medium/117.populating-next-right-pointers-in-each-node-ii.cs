/*
 * @lc app=leetcode.cn id=117 lang=csharp
 * @lcpr version=30201
 *
 * [117] 填充每个节点的下一个右侧节点指针 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start

// Definition for a Node.
// public class Node
// {
//     public int val;
//     public Node left;
//     public Node right;
//     public Node next;

//     public Node() { }

//     public Node(int _val)
//     {
//         val = _val;
//     }

//     public Node(int _val, Node _left, Node _right, Node _next)
//     {
//         val = _val;
//         left = _left;
//         right = _right;
//         next = _next;
//     }
// }

public class Solution
{
    public Node Connect(Node root)
    {
        var q = new Queue<Node>();
        if (root != null)
            q.Enqueue(root);
        while (q.Count > 0)
        {
            var size = q.Count;
            while (size > 0)
            {
                var temp = q.Dequeue();
                if (size > 1)
                    temp.next = q.Peek();
                else
                    temp.next = null;
                if (temp.left != null)
                    q.Enqueue(temp.left);
                if (temp.right != null)
                    q.Enqueue(temp.right);
                size--;
            }
        }
        return root;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5,null,7]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

 */

