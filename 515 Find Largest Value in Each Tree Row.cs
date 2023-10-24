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
    public IList<int> LargestValues(TreeNode root) {
        if (root == null)
            return new List<int>();
        List<int> ans = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (0 < queue.Count)
        {
            int line = queue.Count;
            int max = Int32.MinValue;
            for (int i = 0; i < line; i++)
            {
                TreeNode n = queue.Dequeue();
                max = Math.Max(max, n.val);
                if (n.right != null)
                    queue.Enqueue(n.right);
                if (n.left != null)
                    queue.Enqueue(n.left);
            }
            ans.Add(max);
        }
        return ans;
    }
}