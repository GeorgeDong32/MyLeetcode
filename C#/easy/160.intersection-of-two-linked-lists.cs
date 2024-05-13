/*
 * @lc app=leetcode.cn id=160 lang=csharp
 * @lcpr version=30201
 *
 * [160] 相交链表
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
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var lenA = 0; var lenB = 0;
        var curA = headA; var curB = headB;
        while (curA != null)
        {
            curA = curA.next;
            lenA++;
        }
        while (curB != null)
        {
            curB = curB.next;
            lenB++;
        }
        curA = headA;
        curB = headB;
        return lenA > lenB ? GetIntersection(curA, curB, lenA, lenB) : GetIntersection(curB, curA, lenB, lenA);
    }

    public ListNode? GetIntersection(ListNode longHead, ListNode shortHead, int longLength, int shortLength)
    {
        var curLong = longHead;
        var curShort = shortHead;
        for (var i = 0; i < longLength - shortLength; i++)
        {
            curLong = curLong.next;
        }
        while (curLong != null)
        {
            if (curLong == curShort)
                return curLong;
            curLong = curLong.next;
            curShort = curShort.next;
        }
        return null;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 8\n[4,1,8,4,5]\n[5,6,1,8,4,5]\n2\n3\n
// @lcpr case=end

// @lcpr case=start
// 2\n[1,9,1,2,4]\n[3,2,4]\n3\n1\n
// @lcpr case=end

// @lcpr case=start
// 0\n[2,6,4]\n[1,5]\n3\n2\n
// @lcpr case=end

 */

