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
    int min = Int32.MaxValue;
    int previous = -1;
    public int MinDiffInBST(TreeNode root) {
        Helper (root);
        return min;
    }

    public void Helper (TreeNode root)
    {
        if (root is null)
            return ;
        Helper (root.left);
        if (previous != -1)
            min = Math.Min(min, root.val - previous);
        previous = root.val;
        Helper (root.right);
    }
}