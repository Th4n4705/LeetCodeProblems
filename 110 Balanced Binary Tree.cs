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
    public bool IsBalanced(TreeNode root) {
        if (root == null)
            return true;
        if (Math.Abs (Helper(root.left) - Helper(root.right)) >= 2)
            return false;
        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    private int Helper(TreeNode root, int max = 0)
    {
        if (root == null)
            return max;
        int left = Helper(root.left, max + 1);
        int right = Helper(root.right, max + 1);
        max = left > right ? left : right;
        return max;
    }
}