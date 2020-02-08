namespace PuzzlesAndAlgorithms.LeetCode.Recursion
{
    public static class SwapLinkedList
    {
        public class ListNode
        {
            public ListNode() {}
            public ListNode(int x) { val = x; }
            public int val;
            public ListNode next;
         }
         
        /*
         * Given a linked list, swap every two adjacent nodes and return its head.
         * e.g.  for a list 1-> 2 -> 3 -> 4, one should return the head of list as 2 -> 1 -> 4 -> 3.
         */

        public class Solution
        {
            public ListNode SwapPairs(ListNode head)
            {
                if (head == null || head.next == null)
                {
                    return head;
                }

                var newHeadNode = head.next;
                head.next = SwapPairs(head.next.next);
                newHeadNode.next = head;

                return newHeadNode;
            }
        }
    }
}
