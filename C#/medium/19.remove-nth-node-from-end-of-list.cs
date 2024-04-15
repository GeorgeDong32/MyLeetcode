/*
 * @lc app=leetcode.cn id=19 lang=csharp
 * @lcpr version=30122
 *
 * [19] 删除链表的倒数第 N 个结点
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
/*
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
*/
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var list = new List<ListNode>();
        var cur = head;
        while (cur != null)
        {
            list.Add(cur);
            cur = cur.next;
        }
        var l = list.Count();
        if (l == n)
            return head.next;
        var ln = list[l - n];
        var lnl = list[l - n - 1];
        lnl.next = ln.next;
        return head;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5]\n2\n
// @lcpr case=end

// @lcpr case=start
// [1]\n1\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n1\n
// @lcpr case=end

 */

