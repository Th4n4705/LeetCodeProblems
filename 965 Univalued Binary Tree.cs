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
    public bool IsUnivalTree(TreeNode root) {
        return IsUnivalTreeRec(root, root!.val);
    }

    private bool IsUnivalTreeRec(TreeNode? root, int val)
    {
        if (root == null)
            return true;
        if (root.val != val)
            return false;
        return IsUnivalTreeRec(root.left, val) && IsUnivalTreeRec(root.right, val);
    }
}