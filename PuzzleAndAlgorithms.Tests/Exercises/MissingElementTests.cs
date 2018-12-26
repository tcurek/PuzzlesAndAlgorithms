using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.Exercises;

namespace PuzzlesAndAlgorithms.Tests.Exercises
{
    [TestClass()]
    public class MissingElementTests
    {
        private MissingElement sut;
        private int[] first;
        private int[] second;
        private int expected = 88;

        [TestInitialize]
        public void Given()
        {
            sut = new MissingElement();
            first = new[] {5, 8, 9, 1, 01, 88, 100, 78};
            second = new[] {  8, 9, 5, 01, 1, 78, 100 };
        }

        [TestMethod()]
        public void FindMissingElementBad()
        {
            Assert.AreEqual(expected, sut.FindMissingElementBad(first, second));
        }

        [TestMethod()]
        public void FindMissingElementGood()
        {
            Assert.AreEqual(expected, sut.FindMissingElementGood(first, second));
        }
    }
}
