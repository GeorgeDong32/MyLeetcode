/*
 * @lc app=leetcode.cn id=2181 lang=csharp
 *
 * [2181] 合并零之间的节点
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 */

/* public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
} */

public class Solution
{
    public ListNode MergeNodes(ListNode head)
    {
        var cur = head;
        while (cur.next.next != null)
        {
            if (cur.next.val != 0)
            {
                cur.val += cur.next.val;
                cur.next = cur.next.next;
            }
            else
            {
                cur = cur.next;
            }
        }
        cur.next = null;
        return head;
    }
}
// @lc code=end

