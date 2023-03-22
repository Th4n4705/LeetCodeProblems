/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    TreeNode answer;
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        Helper (cloned, target);
        return answer;
    }

    public void Helper (TreeNode cloned, TreeNode target)
    {
        if (cloned == null)
            return ;
        if (cloned.val == target.val)
            answer = cloned;
        Helper (cloned.left, target);
        Helper (cloned.right, target);
    }
}