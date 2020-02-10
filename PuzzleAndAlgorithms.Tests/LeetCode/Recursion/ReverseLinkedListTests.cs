using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.LeetCode.Recursion;

namespace PuzzlesAndAlgorithms.Tests.LeetCode.Recursion
{
    [TestClass()]
    public class ReverseLinkedListTests
    {
        [TestMethod()]
        public void TestNormalReverseList1()
        {
            var node4 = new ListNode { val = 4 };
            var node3 = new ListNode { val = 3, next = node4 };
            var node2 = new ListNode { val = 2, next = node3 };
            var head = new ListNode { val = 1, next = node2 };

            var sut = new ReverseLinkedList();
            var newHead = sut.ReverseList1(head);
            
            Assert.AreEqual(4, newHead.val);
            Assert.AreEqual(3, newHead.next.val);
            Assert.AreEqual(2, newHead.next.next.val);
            Assert.AreEqual(1, newHead.next.next.next.val);
        }
    }
}
