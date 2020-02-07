using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.LeetCode.Recursion;

namespace PuzzlesAndAlgorithms.Tests.LeetCode.Recursion
{
    [TestClass()]
    public class ReverseStringTests
    {
        [TestMethod()]
        public void ReverseNormalString()
        {
            var input = "Tim";
            var expected = "miT";

            Assert.AreEqual(expected, RecursiveReverseString.Reverse(input));
        }

        [TestMethod()]
        public void ReverseEmptyString()
        {
            var input = "";
            var expected = "";

            Assert.AreEqual(expected, RecursiveReverseString.Reverse(input));
        }

    }
}
