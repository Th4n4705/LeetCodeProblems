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
public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        for (ListNode c = head, n = c.next; n != null; c = n, n = n.next)
            c.next = new ListNode(FindDenominator(c.val, n.val), n);
        return head;
    }

    int FindDenominator(int x, int y)
    {
        while (y > 0)
        {
            int tmp = x % y;
            x = y;
            y = tmp;
        }
        return x;
    }
}