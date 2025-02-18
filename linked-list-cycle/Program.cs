﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> visited = new HashSet<ListNode>();

        while (head != null)
        {
            if (visited.Contains(head))
            {
                return true;
            }

            visited.Add(head);
            head = head.next;
        }

        return false;
    }
}