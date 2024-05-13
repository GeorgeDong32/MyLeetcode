/*
 * @lc app=leetcode.cn id=142 lang=csharp
 * @lcpr version=30201
 *
 * [142] 环形链表 II
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
// public class ListNode
// {
//     public int val;
//     public ListNode next;
//     public ListNode(int x) { val = x; }
// }

public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        var set = new HashSet<ListNode>();
        var cur = head;
        while (cur != null)
        {
            if (!set.Add(cur))
                return cur;
            cur = cur.next;
        }
        return null;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,0,-4]\n1\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n0\n
// @lcpr case=end

// @lcpr case=start
// [1]\n-1\n
// @lcpr case=end

 */

