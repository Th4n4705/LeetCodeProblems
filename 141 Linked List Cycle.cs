/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null)
            return false;
        ListNode s = head;
        ListNode f = head;
        while (f != null && f.next != null)
        {
            s = s.next;
            f = f.next.next;
            if (s == f)
                return true;
        }
        return false;
    }
}