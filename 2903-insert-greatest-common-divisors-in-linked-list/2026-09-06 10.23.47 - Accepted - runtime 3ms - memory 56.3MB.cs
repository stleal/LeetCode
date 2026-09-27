/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if (head == null || head.next == null)
          return head;
        var cursor = head;
        while (cursor.next != null)
        {
          var next = cursor.next;
          cursor.next = new ListNode(
            FindGreatestCommonDenominator(cursor.val, next.val),
            next);
          cursor = next;
        }
        return head;
    }
    public int FindGreatestCommonDenominator(int x, int y)
    {
        x = Math.Abs(x);
        y = Math.Abs(y);
        while (y != 0)
        {
          (x, y) = (y, x % y);
        }
        return x;
    }
}