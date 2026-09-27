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
public class Program {
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums == null || nums.Length == 0)
            return null;
        return Build(nums, 0, nums.Length - 1);
    }
    private static TreeNode Build(int[] nums, int left, int right)
    {
        if (left > right)
            return null;

        int mid = left + (right - left) / 2;
        var node = new TreeNode(nums[mid]);
        node.left = Build(nums, left, mid - 1);
        node.right = Build(nums, mid + 1, right);
        return node;
    }
}