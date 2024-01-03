/*
 * @lc app=leetcode.cn id=2487 lang=csharp
 *
 * [2487] 从链表中移除节点
 */

// @lc code=start
// public class ListNode
// {
//     public int val;
//     public ListNode next;
//     public ListNode(int val = 0, ListNode next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }

public class Solution
{
    //逆序遍历
    public ListNode RemoveNodes(ListNode head)
    {
        var current = head;
        //形成逆序链
        var list = new List<ListNode>();
        while (current is not null)
        {
            list.Add(current);
            current = current.next;
        }
        var max = 0;
        ListNode newhead = null;
        //逆序遍历原链表，当且仅当当前值大于等于右侧最大值时加入新链表
        for (var i = list.Count - 1; i >= 0; i--)
        {
            if (list[i].val >= max)
            {
                max = list[i].val;
                list[i].next = newhead;
                newhead = list[i];
            }
        }
        return newhead;
    }
}
// @lc code=end

