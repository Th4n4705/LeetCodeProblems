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
    int move = 0;

    public int DistributeCoins(TreeNode root) {
        Helper(root);
        return move;
    }

    int Helper(TreeNode root)
    {
        if (root == null)
            return 0;
        int left = Helper (root.left);
        int right = Helper (root.right);
        move += Math.Abs(left) + Math.Abs(right);
        return root.val + left + right - 1;
    }
}