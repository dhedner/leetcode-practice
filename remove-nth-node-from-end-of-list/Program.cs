// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


 public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null)
        {
            return null;
        }

        int size = 0;
        ListNode current = head;

        while (current != null)
        {
            size++;
            current = current.next;
        }

        int targetIndex = size - n;
        int currentIndex = 0;
        
        current = head;
        ListNode prev = null;

        while (currentIndex != targetIndex)
        {
            currentIndex++;
            prev = current;
            current = current.next;
        }

        if (prev != null)
        {
            prev.next = current.next;
        }

        return targetIndex == 0 ? current.next : head;
    }
}