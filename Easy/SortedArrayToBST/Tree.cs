using System.Collections.Generic;

namespace SortedArrayToBST
{
    public static class Tree
    {
        public static TreeNode? ConvertSortedArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;
            return Build(nums, 0, nums.Length - 1);
        }

        private static TreeNode? Build(int[] nums, int left, int right)
        {
            if (left > right)
                return null;

            int mid = left + (right - left) / 2;
            var node = new TreeNode(nums[mid]);
            node.Left = Build(nums, left, mid - 1);
            node.Right = Build(nums, mid + 1, right);
            return node;
        }

        public static List<int> PreOrder(TreeNode? root)
        {
            var res = new List<int>();
            Pre(root, res);
            return res;
        }

        private static void Pre(TreeNode? node, List<int> acc)
        {
            if (node == null) return;
            acc.Add(node.Val);
            Pre(node.Left, acc);
            Pre(node.Right, acc);
        }

        public static List<int> InOrder(TreeNode? root)
        {
            var res = new List<int>();
            In(root, res);
            return res;
        }

        private static void In(TreeNode? node, List<int> acc)
        {
            if (node == null) return;
            In(node.Left, acc);
            acc.Add(node.Val);
            In(node.Right, acc);
        }

        public static List<int> PostOrder(TreeNode? root)
        {
            var res = new List<int>();
            Post(root, res);
            return res;
        }

        private static void Post(TreeNode? node, List<int> acc)
        {
            if (node == null) return;
            Post(node.Left, acc);
            Post(node.Right, acc);
            acc.Add(node.Val);
        }

        public static int[] MergeSort(int[] nums)
        {
            if (nums == null) return System.Array.Empty<int>();
            if (nums.Length <= 1) return (int[])nums.Clone();
            return MergeSortInternal(nums);
        }

        private static int[] MergeSortInternal(int[] arr)
        {
            if (arr.Length <= 1) return arr;
            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];
            System.Array.Copy(arr, 0, left, 0, mid);
            System.Array.Copy(arr, mid, right, 0, right.Length);
            left = MergeSortInternal(left);
            right = MergeSortInternal(right);
            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            int[] merged = new int[left.Length + right.Length];
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j]) merged[k++] = left[i++];
                else merged[k++] = right[j++];
            }
            while (i < left.Length) merged[k++] = left[i++];
            while (j < right.Length) merged[k++] = right[j++];
            return merged;
        }
    }
}
