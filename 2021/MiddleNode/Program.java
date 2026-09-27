/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
/*
 * Problem: Middle of the Linked List
 * Description: Return the middle node of a singly linked list, using O(1) extra space.
 */

class Program
{
    public ListNode middleNode(ListNode head)
    {
        int count, end;
        ListNode cursor;
        count = -1; end = -1;
        cursor = head;
        count = 0;
        // counts how many numbers are in the linked list
        while (cursor != null)
        {
            count++;
            cursor = cursor.next;
        }
        end = count / 2;
        count = 0;
        cursor = head;
        while (count < end)
        {
            cursor = cursor.next;
            count++;
        }
        return cursor;
    }
}
