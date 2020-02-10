using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.LeetCode.Recursion;

namespace PuzzlesAndAlgorithms.Tests.LeetCode.Recursion
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void TestSearchBST()
        {
            var leftThird = new TreeNode(1);
            var rightThird = new TreeNode(3);
            var leftSecond = new TreeNode(2){left = leftThird, right = rightThird};
            var rightSecond = new TreeNode(7);
            var root = new TreeNode(4){left = leftSecond, right = rightSecond};

            var sut = new BinarySearch();

           Assert.AreEqual(sut.SearchBST(root, 7).val, rightSecond.val);
           Assert.AreEqual(sut.SearchBST(root, 1).val, leftThird.val);
           Assert.IsNull(sut.SearchBST(root, 10));
        }
    }
}
