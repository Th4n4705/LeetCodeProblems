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
    private List<int> modes = new();
    private int? curVal = null;
    private int counter = 0;
    private int max = 0;

    public int[] FindMode(TreeNode root) {
        FindModeHelper(root);
        return modes.ToArray();
    }

    private void FindModeHelper(TreeNode node)
    {
        if (node == null)
            return;
        FindModeHelper(node.left);
        counter = (node.val == curVal) ? counter + 1 : 1;
        if (counter == max)
            modes.Add(node.val);
        else if (max < counter)
        {
            max = counter;
            modes.Clear();
            modes.Add(node.val);
        }
        curVal = node.val;

        FindModeHelper(node.right);
    }


}