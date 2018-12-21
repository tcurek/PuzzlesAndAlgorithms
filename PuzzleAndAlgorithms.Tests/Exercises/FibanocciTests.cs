using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.Exercises;

namespace PuzzlesAndAlgorithms.Tests.Exercises
{
    [TestClass()]
    public class FibanocciTests
    {
        [TestMethod()]
        public void GenerateFibanocciWhenBoundsLessThan2()
        {
            var sut = new Fibanocci();
            var result = sut.GenerateFibanocci(1);
            
            CollectionAssert.AreEqual(new[]{0}, result);
        }

        [TestMethod()]
        public void GenerateFibanocciWithBounds10()
        {
            var expected = new[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34};
            var sut = new Fibanocci();
            var result = sut.GenerateFibanocci(10);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
