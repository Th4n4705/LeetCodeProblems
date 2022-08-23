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
    public bool IsPalindrome(ListNode head)
    {
        List<int> nodeList = FillList(head);
        
        int i = 0;
        int mid = nodeList.Count / 2;
        int last = nodeList.Count - 1;
        while (i < mid)
        {
            if (nodeList[i] != nodeList[last])
                return false;
            i++;
            last--;
        }
        return true;
    }
    
    public List<int> FillList(ListNode head)
    {
        List<int> nodeList = new List<int>();
        
        while (head != null)
        {
            nodeList.Add(head.val);
            head = head.next;
        }
        
        return nodeList;
    }
}