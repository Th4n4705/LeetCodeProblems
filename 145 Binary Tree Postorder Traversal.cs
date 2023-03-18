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
    List<int> ans = new();

    public void Helper (TreeNode root)
    {
        if (root != null)
        {
            Helper (root.left);
            Helper (root.right);
            ans.Add(root.val);
        }
    }

    public IList<int> PostorderTraversal(TreeNode root) {
        Helper(root);
        return ans;
    }
}