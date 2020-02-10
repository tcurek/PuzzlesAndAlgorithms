using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.LeetCode.Recursion;

namespace PuzzlesAndAlgorithms.Tests.LeetCode.Recursion
{
    [TestClass()]
    public class SwapLinkedListTests
    {
        [TestMethod()]
        public void EvenLinkedList()
        {
            var node4 = new ListNode { val = 4};
            var node3 = new ListNode { val = 3, next = node4};
            var node2 = new ListNode { val = 2, next = node3};
            var head = new ListNode { val = 1, next = node2};

            var sut = new SwapLinkedList.Solution();
            var result = sut.SwapPairs(head);

            Assert.AreEqual(2, result.val);
            Assert.AreEqual(1, result.next.val);
            Assert.AreEqual(4, result.next.next.val);
            Assert.AreEqual(3, result.next.next.next.val);
        }
    }
}
