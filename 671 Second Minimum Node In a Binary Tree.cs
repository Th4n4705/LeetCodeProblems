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
    int first = 0;
    int second = -1;
    public int FindSecondMinimumValue(TreeNode root) {
        first = root.val;
        FindSecond(root);
        return second;
    }

    void FindSecond(TreeNode node)
    {
        if (node == null)
            return ;
        if ((second == -1 || node.val < second) && node.val != first)
            second = node.val;
        FindSecond(node.left);
        FindSecond(node.right);
    }
}