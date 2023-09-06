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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        ListNode[] ans = new ListNode[k];
        if (head == null)
            return ans;
        int counter = 1;
        ListNode tmp = head;
        while (tmp.next != null)
        {
            tmp = tmp.next;
            counter++;
        }
        ListNode node = head;
        int dif = counter - ((counter / k) * k);
        for (int i = 0; node != null && i < k; i++, dif--)
        {
            ans[i] = node;
            ListNode prv = new ListNode(node.val);
            for (int j = 0; j < (counter / k) + (dif <= 0 ? 0 : 1); j++)
            {
                prv = node;
                node = node.next;
            }
            prv.next = null;
        }
        return ans;
    }
}