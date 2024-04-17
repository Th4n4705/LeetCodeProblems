/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public string SmallestFromLeaf(TreeNode root) {
        string smallestText = "";
        Queue<KeyValuePair<TreeNode, string>> q = new();
        q.Enqueue(new KeyValuePair<TreeNode, string>(root, ((char)(root.val + 'a')).ToString()));
        while (q.Count > 0)
        {
            var pairValue = q.Dequeue();
            TreeNode n = pairValue.Key;
            string current = pairValue.Value;
            if (n.left == null && n.right == null)
            {
                if (string.IsNullOrEmpty(smallestText))
                    smallestText = current;
                else
                    smallestText = current.CompareTo(smallestText) >= 0 ? smallestText : current;
            }
            if (n.left != null)
                q.Enqueue(new KeyValuePair<TreeNode, string>(n.left, (char)(n.left.val + 'a') + current));
            if (n.right != null)
                q.Enqueue(new KeyValuePair<TreeNode, string>(n.right, (char)(n.right.val + 'a') + current));
        }
        return smallestText;
    }
}