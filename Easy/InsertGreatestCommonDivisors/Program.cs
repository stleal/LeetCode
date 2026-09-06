
public class Program {

  public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
      this.val = val;
      this.next = next;
    }
  }

  public static void Main(string[] args) {
    ListNode head = new ListNode(18, new ListNode(6, new ListNode(10, new ListNode(3))));
    var result = InsertGreatestCommonDivisors(head);
    while (result != null)
    {
        Console.WriteLine(result.val);
        result = result.next;
    }
  }

  public static ListNode InsertGreatestCommonDivisors(ListNode head) {
      if (head.next == null)
          return head;
      var cursor = head;
      while (cursor.next != null)
      {
          var gcd = FindGreatestCommonDenominator(cursor.val, cursor.next.val);
          var prevNext = cursor.next;
          ListNode n = new ListNode(gcd, prevNext);
          cursor.next = n;
          n.next = prevNext;
          cursor = n.next;
      }
      return head;
  }

  public static int FindGreatestCommonDenominator(int x, int y)
  {
      var gcd = 0;
      var smallest = (x < y) ? x : y;
      var largest = (x > y) ? x : y;
      for (int i = 1; i <= smallest; i++)
      {
          gcd = ((largest % i == 0) && (smallest % i == 0))? i : gcd;
      }
      return gcd;
  }
}