/*
 * @lc app=leetcode.cn id=82 lang=csharp
 *
 * [82] 删除排序链表中的重复元素 II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        while (head != null)
        {
            if (head.next != null && head.val == head.next.val)
            {
                while (head.next != null && head.val == head.next.val)
                {
                    head = head.next;
                }
                prev.next = head.next;
            }
            else
            {
                prev = prev.next;
            }
            head = head.next;
        }
        return dummy.next;
    }
}
// @lc code=end

