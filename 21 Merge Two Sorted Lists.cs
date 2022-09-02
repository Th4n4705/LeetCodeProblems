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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null)
            return null;
        List<int> allLists = new List<int>();
        
        FillList(allLists, list1);
        FillList(allLists, list2);

        allLists.Sort();
        return FillNodes(allLists);
    }
    
    public void FillList(List<int> allLists, ListNode list)
    {
        while (list != null)
        {
            allLists.Add(list.val);
            list = list.next;
        }
    }
    
    public ListNode FillNodes(List<int> allLists)
    {
        ListNode headNode = new ListNode();
        ListNode tmp = headNode;
        int i = 1;
        
        if (allLists.Count > 0)
            headNode.val = allLists[0];
        while (i < allLists.Count)
        {
            ListNode newNode = new ListNode();
            newNode.val = allLists[i];
            headNode.next = newNode;
            headNode = headNode.next;
            i++;
        }
        return tmp;
    }
}