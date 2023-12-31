/*
 * @lc app=leetcode.cn id=1290 lang=csharp
 *
 * [1290] 二进制链表转整数
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
    public int GetDecimalValue(ListNode head)
    {
        var s = "";
        var now = head;
        while (now != null)
        {
            s += $"{now.val}";
            now = now.next;
        }
        return Convert.ToInt32(s, 2);
    }
}
// @lc code=end

