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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if (head == null)
            return head;
        ListNode tmpNode = new ListNode(0);
        tmpNode.next = head;
        ListNode prv = tmpNode;
        for (int i = 0; i < left - 1; ++i)
            prv = prv.next;
        ListNode current = prv.next;
        for (int i = 0; i < right - left; ++i)
        {
            ListNode nxt = current.next;
            current.next = nxt.next;
            nxt.next = prv.next;
            prv.next = nxt;
        }
        return tmpNode.next;
    }
}