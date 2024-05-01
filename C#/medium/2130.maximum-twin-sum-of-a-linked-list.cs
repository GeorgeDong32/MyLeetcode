/*
 * @lc app=leetcode.cn id=2130 lang=csharp
 * @lcpr version=30122
 *
 * [2130] 链表最大孪生和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start

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

public class Solution
{
    public int PairSum(ListNode head)
    {
        var list = new List<int>();
        var cur = head;
        while (cur != null)
        {
            list.Add(cur.val);
            cur = cur.next;
        }
        var l = 0; var r = list.Count - 1;
        var ans = 0;
        while (l < r)
        {
            ans = Math.Max(ans, list[l] + list[r]);
            l++; r--;
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,4,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [4,2,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,100000]\n
// @lcpr case=end

 */

