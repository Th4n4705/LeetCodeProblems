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
    int diam = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        BiggestDiam (root);
        return diam;
    }

    int BiggestDiam (TreeNode root)
    {
        if (root == null)
            return 0;
        int left = BiggestDiam (root.left);
        int right = BiggestDiam (root.right);
        diam = right + left > diam ? right + left : diam;
        return Math.Max (left, right) + 1;

    }
}