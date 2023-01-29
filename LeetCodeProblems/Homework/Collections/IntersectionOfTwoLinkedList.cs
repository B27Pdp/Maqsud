public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        List<ListNode> list1 = new List<ListNode>();
        List<ListNode> list2 = new List<ListNode>();
        ListNode temp1 = headA;
        ListNode temp2 = headB;
        while (temp1 is not null)
        {
            list1.Add(temp1);
            temp1 = temp1.next;
        }
        while (temp2 is not null)
        {
            list2.Add(temp2);
            temp2 = temp2.next;
        }
        return list1.FirstOrDefault(x => list2.Contains(x));
    }
}
