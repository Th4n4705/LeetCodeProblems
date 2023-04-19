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
    public int LongestZigZag(TreeNode root) {
        int left = Helper (root, true, 0);
        int right = Helper (root, false, 0);
        int ans = Math.Max(left, right);
        return ans - 1;
    }

    int Helper (TreeNode node, bool isLeft, int length)
    {
        if(node == null)
            return length;
        int current = isLeft ?  Helper(node.right, !isLeft, length + 1) : Helper(node.left, !isLeft, length + 1);
        int alternate = isLeft ? Helper(node.left, isLeft, 1) : Helper(node.right, isLeft, 1);
        int maxLength = Math.Max(current, alternate);
        return maxLength;
    }
}