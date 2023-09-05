/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        return CCNode (head, new Dictionary<Node, Node>());
    }

    private Node CCNode (Node head, Dictionary<Node, Node> dc)
    {
        if (head == null)
            return null;
        if (!dc.TryGetValue(head, out var n))
        {
            n = new Node(head.val);
            dc.Add(head, n);
            n.next = CCNode (head.next, dc);
            n.random = CCNode (head.random, dc);
        }
        return n;
    }
}