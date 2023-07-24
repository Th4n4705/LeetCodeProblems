/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode hA, ListNode hB) {
        if (hA == null || hB == null)
            return null;
        ListNode n1 = hA;
        ListNode n2 = hB;
        HashSet<ListNode> HSA = new();
        HashSet<ListNode> HSB = new();
        while (n1 != null || n2 != null)
        {
            if (n1 != null)
            {
                if (HSB.Contains(n1))
                    return n1;
                HSA.Add(n1);
                n1 = n1.next;
            } 
            if (n2 != null)
            {
                if (HSA.Contains(n2))
                    return n2;
                HSB.Add(n2);
                n2 = n2.next;
            }
        }
        return null;
    }
}