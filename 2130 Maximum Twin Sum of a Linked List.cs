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
    public int PairSum(ListNode head) {
        ListNode n1 = head;
        ListNode n2 = head;
        Stack<int> s = new();
        while (n2 != null)
        {
            s.Push(n1.val);
            n1 = n1.next;
            n2 = n2.next.next;
        }
        int max = 0;
        while (s.Count > 0)
        {
            max = Math.Max(max, s.Pop() + n1.val);
            n1 = n1.next;
        }
        return max;
    }
}