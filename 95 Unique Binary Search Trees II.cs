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
    public IList<TreeNode> GenerateTrees(int n) {
        return Helper_GenerateTrees(1, n);
    }

    private IList<TreeNode> Helper_GenerateTrees(int left, int right)
    {
        IList<TreeNode> ans = new List<TreeNode>();
        if (left > right)
        {
            ans.Add(null);
            return ans;
        }
        for (int i = left; i <= right; i++)
        {
            IList<TreeNode> leftNodes = Helper_GenerateTrees(left, i - 1);
            IList<TreeNode> rightNodes = Helper_GenerateTrees(i + 1, right);
            foreach (TreeNode lefty in leftNodes)
            {
                foreach (TreeNode righty in rightNodes)
                {
                    TreeNode node = new TreeNode(i, lefty, righty);
                    ans.Add(node);
                }
            }
        }
        return ans;
    }
}