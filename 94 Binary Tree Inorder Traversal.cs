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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> ls = new();
        Helper (root, ls);
        return ls.ToArray();
    }

    private void Helper (TreeNode root, List<int> ls)
    {
        if (root == null)
            return ;
        Helper (root.left, ls);
        ls.Add(root.val);
        Helper (root.right, ls);
    }
}