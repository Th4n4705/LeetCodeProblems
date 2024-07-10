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
    public bool IsCousins(TreeNode root, int x, int y) {
        Dictionary<int, (int p, int d)> dc = new();
        DFS (root, dc, 0, 0);
        return (dc[x].d == dc[y].d) && (dc[x].p != dc[y].p);
    }

    void DFS(TreeNode node, Dictionary<int, (int p, int d)> dc, int p, int d)
    {
        if (node != null)
        {
            dc.Add(node.val, (p, d));
            DFS (node.left, dc, node.val, d + 1);
            DFS (node.right, dc, node.val, d + 1);
        }
    }
}