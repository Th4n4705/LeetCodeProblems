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
    public ListNode SwapNodes(ListNode head, int k) {
        ListNode first = head;
        ListNode second = head;
        for (int i = 1; i < k; i++)
            first = first.next;
        ListNode current = first;
        while (current.next != null)
        {
            current = current.next;
            second = second.next;
        }
        int swappedValue = first.val;
        first.val = second.val;
        second.val = swappedValue;
        return head;
    }
}