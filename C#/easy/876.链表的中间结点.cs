/*
 * @lc app=leetcode.cn id=876 lang=csharp
 *
 * [876] 链表的中间结点
 */

// @lc code=start
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        var count = 0;
        ListNode current = head;
        while (current is not null)
        {
            count++;
            current = current.next;
        }
        count = count % 2 == 0 ? count / 2 : (count - 1) / 2;
        current = head;
        for (; count > 0; count--)
        {
            current = current.next;
        }
        return current;
    }
}
// @lc code=end

