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
    public IList<double> AverageOfLevels(TreeNode root) {
        List<double> ans = new ();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            double sum = 0;
            int queueSize = queue.Count;
            for (int i = 0; i < queueSize; i++)
            {
                var lvlNode = queue.Dequeue();
                sum += lvlNode.val;
                if (lvlNode.left != null)
                    queue.Enqueue(lvlNode.left);
                if (lvlNode.right != null)
                    queue.Enqueue(lvlNode.right);
            }
            ans.Add(sum / queueSize);
        }
        return ans;
    }
}