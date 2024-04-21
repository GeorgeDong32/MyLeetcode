/*
@lc app=leetcode.cn id=2095 lang=csharp
@lcpr version=30122
 *
[2095] 删除链表的中间节点
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
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head == null || head.next == null)
            return null;
        var list = new List<ListNode>();
        var cur = head;
        while (cur != null)
        {
            list.Add(cur);
            cur = cur.next;
        }
        var l = list.Count;
        var hf = double.Floor(l / 2);
        list[(int)hf - 1].next = hf + 1 < l ? list[(int)hf + 1] : null;
        return list[0];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,4,7,1,2,6]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4]\n
// @lcpr case=end

// @lcpr case=start
// [2,1]\n
// @lcpr case=end

 */

