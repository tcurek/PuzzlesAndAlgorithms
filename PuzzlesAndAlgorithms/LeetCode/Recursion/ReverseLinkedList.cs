using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzlesAndAlgorithms.LeetCode.Recursion
{
    /*
     * Reverse a singly linked list.
     *
     * Example:
     * Input: 1->2->3->4->5->NULL
     * Output: 5->4->3->2->1->NULL
     *
     */

    public class ReverseLinkedList
    {
        public ListNode ReverseList1(ListNode node)
        {
            if (node == null || node.next == null)
            {
                return node;
            }

            var newHeadNode = ReverseList1(node.next);
            node.next.next = node;
            node.next = null;

            return newHeadNode;
        }

    }
}
