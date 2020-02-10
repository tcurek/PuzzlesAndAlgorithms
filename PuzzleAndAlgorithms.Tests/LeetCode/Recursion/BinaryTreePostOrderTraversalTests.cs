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

        private TreeNode GenerateTree1()
        {
            //      7
            //  5       8
            //      1       41
            
            var subRoot = new TreeNode(8) {left = new TreeNode(1), right = new TreeNode(41)};
            var root = new TreeNode(7) {left = new TreeNode(5), right = subRoot};
            return root;
        }
    }
}