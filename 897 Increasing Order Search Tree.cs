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
    static TreeNode ans = new();
    TreeNode start = ans;

    public TreeNode IncreasingBST(TreeNode root) {
        if (root == null)
            return null;
        IncreasingBST(root.left);
        ans.right = new TreeNode(root.val);
        ans = ans.right;
        IncreasingBST(root.right);
        return start.right;
    }
}