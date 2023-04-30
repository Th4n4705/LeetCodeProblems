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
    public int SumRootToLeaf(TreeNode root) {
        int sum = 0;
        Helper(root, 0, ref sum);
        return sum;
    }

    public void Helper(TreeNode node, int current, ref int sum)
    {
        if (node == null)
            return;
        current *= 2;
        current += node.val;
        if (node.left == null && node.right == null)
        {
            sum += current;
            return;
        }
        Helper(node.left, current, ref sum);
	    Helper(node.right, current, ref sum);
    }
}