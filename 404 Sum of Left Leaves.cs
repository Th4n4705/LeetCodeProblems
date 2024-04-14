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
    int sum = 0;
    public int SumOfLeftLeaves(TreeNode root) {
        Helper (root, false);
        return sum;
    }

    void Helper(TreeNode root, bool sides)
    {
        if (root == null)
            return;
        if (sides && root.left == null && root.right == null)
            sum += root.val;
        Helper (root.left, true);
        Helper (root.right, false);
    }
}