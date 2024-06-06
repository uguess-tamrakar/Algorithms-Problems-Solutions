using static Solutions;

public class LinkedLists
{
    public static void DeleteNode(ListNode node)
    {
        if (node != null)
        {
            node.val = node.next!.val;
            node.next = node.next.next;
        }
    }

    public static void LinkedListInsertAndSort(ListNode head, ListNode newNode)
    {
        if (head == null) newNode.next = head;
        else
        {
            ListNode current = head;

            while (current.next != null && current.next.val < newNode.val)
                current = current.next;

            newNode.next = current.next;
            current.next = newNode;
        }
    }
}