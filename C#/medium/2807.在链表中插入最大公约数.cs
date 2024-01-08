/*
 * @lc app=leetcode.cn id=2807 lang=csharp
 *
 * [2807] 在链表中插入最大公约数
 */

// @lc code=start

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
    public ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        var current = head;
        while (current.next != null)
        {
            var temp = new ListNode(GCD(current.val, current.next.val));
            var nextcur = current.next;
            current.next = temp;
            temp.next = nextcur;
            current = nextcur;
        }
        return head;
    }

    private static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b) a %= b;
            else b %= a;
        }
        return a | b;
    }
}
// @lc code=end

