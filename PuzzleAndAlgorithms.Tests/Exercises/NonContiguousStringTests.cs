using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.Exercises;

namespace PuzzlesAndAlgorithms.Tests.Exercises
{
    [TestClass()]
    public class NonContiguousStringTests
    {
        [TestMethod()]
        public void FindLargestCommonMatch()
        {
            var sut = new NonContiguousString();
            Assert.AreEqual("bd", sut.LargestCommonStringGood("abcd","btxd"));
        }

        [TestMethod()]
        public void FindLargestCommonMatchWhenFirstSmaller()
        {
            var sut = new NonContiguousString();
            Assert.AreEqual("x", sut.LargestCommonStringGood("x", "btxd"));
        }

        [TestMethod()]
        public void FindLargestCommonMatchWhenFirstLarger()
        {
            var sut = new NonContiguousString();
            Assert.AreEqual("bd", sut.LargestCommonStringGood("abcde", "btxd"));
        }

        [TestMethod()]
        public void FindLargestCommonMatchWhenFirstEmpty()
        {
            var sut = new NonContiguousString();
            Assert.AreEqual(string.Empty, sut.LargestCommonStringGood(string.Empty, "btxd"));
        }

        [TestMethod()]
        public void FindLargestCommonMatchWhenSecondEmpty()
        {
            var sut = new NonContiguousString();
            Assert.AreEqual(string.Empty, sut.LargestCommonStringGood("btxd", string.Empty));
        }
    }
}
