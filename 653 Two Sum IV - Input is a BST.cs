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
    HashSet<int> hS = new HashSet<int>();
    public bool FindTarget(TreeNode root, int k) {
        if (root == null)
            return false;
        if (hS.Contains(k - root.val))
            return true;
        else
            hS.Add(root.val);
        return FindTarget (root.left, k) || FindTarget (root.right, k);
    }
}