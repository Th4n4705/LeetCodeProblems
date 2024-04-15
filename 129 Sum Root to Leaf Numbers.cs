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
    public int SumNumbers(TreeNode root) {
        if (root == null)
            return 0;
        Queue<TreeNode> rootQ = new();
        Queue<int> sumQ = new();
        rootQ.Enqueue(root);
        sumQ.Enqueue(root.val);
        int ans = 0;
        while (rootQ.Count > 0)
        {
            TreeNode n = rootQ.Dequeue();
            int s = sumQ.Dequeue();
            if (n.right == null && n.left == null)
                ans += s;
            if (n.right != null)
            {
                sumQ.Enqueue ((s * 10) + n.right.val);
                rootQ.Enqueue (n.right);
            }
            if (n.left != null)
            {
                sumQ.Enqueue ((s * 10) + n.left.val);
                rootQ.Enqueue (n.left);
            }
        }
        return ans;
    }
}