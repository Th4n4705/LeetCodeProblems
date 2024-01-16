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
    public ListNode MiddleNode(ListNode head) {
        if (head == null)
            return null;
        ListNode ans = head;
        ListNode fasterX = head.next;
        while (fasterX != null)
        {
            ans = ans.next;
            fasterX = fasterX.next;
            if (fasterX != null)
                fasterX = fasterX.next;
        }
        return ans;
    }
}