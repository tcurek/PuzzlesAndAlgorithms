using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.LeetCode.Recursion;
using System.Collections.Generic;

namespace PuzzlesAndAlgorithms.Tests.LeetCode.Recursion
{
    [TestClass()]
    public class BinaryTreePostOrderTraversalTests
    {
        [TestMethod()]
        public void Solution1PostOrderTraversal()
        {
            var expected = new List<int> {5, 1, 41, 8, 7};
            var result = BinaryTreePostOrderTraversal.Solution1(GenerateTree1());
            
            Assert.AreEqual(expected.Count, result.Count);

            for (int j = 0; j < expected.Count; j++)
            {
                Assert.AreEqual(expected[j], result[j]);
            }
        }

        //[TestMethod()]
        //public void Solution2PostOrderTraversal()
        //{
        //    var expected = new List<int> { 5, 1, 41, 8, 7 };
        //    var result = BinaryTreePostOrderTraversal.Solution2(GenerateTree1());

        //    Assert.AreEqual(expected.Count, result.Count);

        //    for (int j = 0; j < expected.Count; j++)
        //    {
        //        Assert.AreEqual(expected[j], result[j]);
        //    }
        //}

        private BinaryTreePostOrderTraversal.TreeNode GenerateTree1()
        {
            //      7
            //  5       8
            //      1       41
            
            var subRoot = new BinaryTreePostOrderTraversal.TreeNode(8) {left = new BinaryTreePostOrderTraversal.TreeNode(1), right = new BinaryTreePostOrderTraversal.TreeNode(41)};
            var root = new BinaryTreePostOrderTraversal.TreeNode(7) {left = new BinaryTreePostOrderTraversal.TreeNode(5), right = subRoot};
            return root;
        }
    }
}
