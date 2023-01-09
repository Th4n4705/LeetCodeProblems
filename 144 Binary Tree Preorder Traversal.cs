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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> newList = new List<int>();
        FillIt(root, newList);
        return newList;
    }

    public void FillIt(TreeNode node, IList<int> List)
    {
        if (node == null)
            return;
        List.Add(node.val);
        FillIt(node.left, List);
        FillIt(node.right, List);
    }
}