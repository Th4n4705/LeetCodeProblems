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
    public ListNode Partition(ListNode head, int x) {
        ListNode ans = null;
        List<int> ls = new();
        while (head != null)
        {
            ls.Add(head.val);
            head = head.next;
        }
        List<int> s = new();
        for (int i = 0; i < ls.Count; i++)
        {
            if (ls[i] < x)
                s.Add(ls[i]);
        }
        for (int i = 0; i < ls.Count; i++)
        {
            if (ls[i] >= x)
                s.Add(ls[i]);
        }
        for (int i = s.Count - 1; i >= 0; i--)
        {
            ListNode node = new(s[i]);
            node.next = ans;
            ans = node;
        }
        return ans;
    }
}