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
    public ListNode DoubleIt(ListNode head) {
        if (head.val > 4)
            head = new ListNode(0, head);
        for (ListNode n = head; n != null; n = n.next)
        {
            n.val = (n.val * 2) % 10;
            if (n.next != null && n.next.val > 4)
                n.val++;
        }
        return head;
    }
}