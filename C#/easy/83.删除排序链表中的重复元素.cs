/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
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
        var dummy = new ListNode(int.MaxValue, head);
        for (var (prev, curr) = (dummy, head); curr is not null;)
        {
            for (; prev.val == (curr?.val ?? int.MaxValue); curr = curr.next) { }
            (prev.next, prev) = (curr, curr);
        }
        return dummy.next;
    }
}
// @lc code=end

