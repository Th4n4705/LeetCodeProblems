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
    public ListNode ReverseList(ListNode head) {
        ListNode LN = null;
        while (head != null)
        {
            ListNode next = head.next;
            head.next = LN;
            LN = head;
            head = next;
        }
        return LN;
    }
}