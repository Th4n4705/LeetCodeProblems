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
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        if (head == null || head.next == null || head.next.next == null)
            return new int[] {-1, -1};
        List<int> ls = new();
        ListNode prev = head;
        ListNode curr = head.next;
        ListNode next = curr.next;
        int ind = 1;
        while (next != null)
        {
            if ((curr.val > prev.val && curr.val > next.val) || (curr.val < prev.val && curr.val < next.val))
                ls.Add(ind);
            prev = curr;
            curr = next;
            next = next.next;
            ind++;
        }
        if (ls.Count < 2)
            return new int[] {-1, -1};
        int min = int.MaxValue;
        int max = ls[ls.Count - 1] - ls[0];
        for (int i = 1; i < ls.Count; i++)
            min = Math.Min(min, ls[i] - ls[i - 1]);
        return new int[] {min, max};
    }
}