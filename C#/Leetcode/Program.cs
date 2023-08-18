/*Q203*/
var sol = new Solution();

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
    public ListNode RemoveElements(ListNode head, int val)
    {
        var current = head;
        ListNode last = null;
        while (current != null)
        {
            if (current.val == val)
            {
                if (current != head)
                {
                    last.next = current.next;
                    current = current.next;
                    last = last;
                }
                else
                {
                    head = current.next;
                    current = current.next;
                    last = null;
                }
            }
            else
            {
                last = current;
                current = current.next;
            }
        }
        return head;
    }
}