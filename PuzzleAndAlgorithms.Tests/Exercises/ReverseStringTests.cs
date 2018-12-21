using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.Exercises;

namespace PuzzlesAndAlgorithms.Tests.Exercises
{
    [TestClass()]
    public class ReverseStringTests
    {
        [TestMethod()]
        public void GetReversedStringWhenEmpty()
        {
            var result = string.Empty;
            var sut = new ReverseString();
            Assert.AreEqual(result, sut.GetReversedString(string.Empty));
        }

        [TestMethod()]
        public void GetReversedString()
        {
            var result = "raB ooF";
            var sut = new ReverseString();
            Assert.AreEqual(result, sut.GetReversedString("Foo Bar"));
        }
    }
}
