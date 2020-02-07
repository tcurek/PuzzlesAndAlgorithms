using System;
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

        [TestMethod()]
        public void ReverseString1()
        {
            var input = new []{'h','e','l','l','o'};
            var expected = new[] { 'o', 'l', 'l', 'e', 'h' };
            var result = RecursiveReverseString.ReverseString(input);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void ReverseString2()
        {
            var input = new[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            var expected = new[] { 'h', 'a', 'n', 'n', 'a', 'H' };
            var result = RecursiveReverseString.ReverseString(input);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
