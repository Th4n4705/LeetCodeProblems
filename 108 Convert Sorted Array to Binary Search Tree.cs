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
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums == null || nums.Length == 0)
            return null;
        return Helper(nums, 0, nums.Length - 1);
    }

    private TreeNode Helper(int[] nums, int start, int end)
    {
        TreeNode current = null;
        int currentIndex = end + (start - end) / 2;
        if (start <= end)
        {
            current = new TreeNode(nums[currentIndex]);
            current.left = Helper(nums, start, currentIndex - 1);
            current.right = Helper(nums, currentIndex + 1, end);
        }
        return current;
    }
}