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
    List<int> ls = new();

    public int GetMinimumDifference(TreeNode root) {
        FillList(root);
        ls.Sort();
        int min = Int32.MaxValue;
        for (int i = 1; i < ls.Count; i++)
            if (ls[i] - ls[i - 1] < min)
                min = ls[i] - ls[i - 1];
        return min;
    }

    private void FillList(TreeNode root)
    {
        if (root == null)
            return;
        ls.Add(root.val);
        FillList(root.left);
        FillList(root.right);
    }
}