using System;
using SortedArrayToBST;

public class Program
{
    public static void Main()
    {
      int[] nums = { 5, 2, 1, 3, 7, 6 };
      Console.WriteLine("Unsorted: " + string.Join(", ", nums));

      var sorted = Tree.MergeSort(nums);
      Console.WriteLine("Sorted: " + string.Join(", ", sorted));

      var root = Tree.ConvertSortedArray(sorted);
      Console.WriteLine("PreOrder: " + string.Join(", ", Tree.PreOrder(root)));
      Console.WriteLine("InOrder: " + string.Join(", ", Tree.InOrder(root)));
      Console.WriteLine("PostOrder: " + string.Join(", ", Tree.PostOrder(root)));

      // Keep console open when running from IDE
      Console.ReadLine();
    }
}