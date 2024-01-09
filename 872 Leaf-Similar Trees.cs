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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> tree1 = new();
        List<int> tree2 = new();
        DFS(root1, tree1);
        DFS(root2, tree2);
        return tree1.SequenceEqual(tree2);
    }

    private void DFS (TreeNode node, List<int> tree)
    {
        if (node == null)
            return ;
        if (node.left == null && node.right == null)
            tree.Add(node.val);
        DFS (node.left, tree);
        DFS (node.right, tree);
    }
}