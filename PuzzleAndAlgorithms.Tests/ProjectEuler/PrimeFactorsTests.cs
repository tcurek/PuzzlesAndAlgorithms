using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.ProjectEuler;

namespace PuzzlesAndAlgorithms.Tests.ProjectEuler
{
    [TestClass()]
    public class PrimeFactorsTests
    {
        [TestMethod()]
        public void ReturnsLargePrimeFactor()
        {
            var sut = new PrimeFactors();
            Assert.AreEqual(6857, sut.maxPrimeFactors(600851475143));
        }
    }
}
