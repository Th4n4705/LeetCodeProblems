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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        List<int> list = new List<int>();
        
        FillListWithL1(list , l1); //fill The list with L1
                
        AccumulateListWithL2(list , l2); // accumulate list to l2;
        
        return TheNewListNode(list);
    }
    
    public void FillListWithL1(List<int> list , ListNode l1)
    {        
        while (l1 != null)
        {
            list.Add(l1.val);
            l1 = l1.next;
        }
    }
    
    public void AccumulateListWithL2(List<int> list , ListNode l2)
    {
        int i = 0;
        int valueOfTwo = 0;
        int rest = 0;
        while (l2 != null)
        {
            if (list.Count <= i)
                list.Add(0);
            valueOfTwo = l2.val + list[i] + rest;
            if (valueOfTwo < 10)
            {
                rest = 0;
                list[i] = valueOfTwo;
            }
            else
            {
                rest = valueOfTwo / 10;
                list[i] = valueOfTwo % 10;                
            }
            l2 = l2.next;
            i++;
        }
        while (i < list.Count)
        {
            valueOfTwo = list[i] + rest;
            if (valueOfTwo < 10)
            {
                rest = 0;
                list[i] = valueOfTwo;
            }
            else
            {
                rest = valueOfTwo / 10;
                list[i] = valueOfTwo % 10;                
            }
            i++;
        }
        if (rest != 0)
            list.Add (rest);
    }
    
    public ListNode TheNewListNode(List<int> list)
    {
        // first node
        ListNode node = new ListNode();
        node.val = list[0];
        node.next = null;
                
        int i = 1; 
        ListNode tmp = node;
        
        while (i < list.Count)
        {
            tmp = NewNode(tmp, list[i]);       
            i++;
        }
        return node;
    }
    
    public ListNode NewNode(ListNode node, int valueL)
    {
        ListNode tmp = new ListNode();
        tmp.val = valueL;
        tmp.next = null;
        node.next = tmp;
        
        return tmp;
    }
}