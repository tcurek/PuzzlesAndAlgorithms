using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.Exercises;

namespace PuzzleAndAlgorithms.Tests.Exercises
{
    [TestClass()]
    public class FirstLetterOfFirstAndLastWordCapTests
    {
        [TestMethod()]
        public void VerifyFirstLetterOfFirstAndLastWordCapCall()
        {
            var input = "hI MY naME is tIm.";
            var expected = "Hi my name is Tim.";

            var sut = new FirstLetterOfFirstAndLastWordCap();
            Assert.AreEqual(expected, sut.CapitalizeFirstLetterOfFirstAndLastWord(input));
        }

        [TestMethod()]
        public void VerifyFirstLetterOfFirstAndLastWordCap2()
        {
            var input = "HI MY naME is TIm.";
            var expected = "Hi my name is Tim.";

            var sut = new FirstLetterOfFirstAndLastWordCap();
            Assert.AreEqual(expected, sut.CapitalizeFirstLetterOfFirstAndLastWord(input));
        }

        [TestMethod()]
        public void VerifyFirstLetterOfFirstAndLastWordCapWhenNull()
        {
            string input = null;
            var sut = new FirstLetterOfFirstAndLastWordCap();
            Assert.IsNull(sut.CapitalizeFirstLetterOfFirstAndLastWord(input));
        }
    }
}
