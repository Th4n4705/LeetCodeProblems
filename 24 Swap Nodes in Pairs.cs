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
    public ListNode SwapPairs(ListNode head) {
        ListNode tmpNode = new (-1, head);
        ListNode prevNode = tmpNode;
        while (prevNode.next != null && prevNode.next.next != null)
        {
            ListNode ANode = prevNode.next;
            ListNode BNode = prevNode.next.next;
            ANode.next = BNode.next;
            BNode.next = ANode;
            prevNode.next = BNode;
            prevNode = ANode;
        }
        return tmpNode.next;
    }
}