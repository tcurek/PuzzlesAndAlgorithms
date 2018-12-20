using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.ProjectEuler;

namespace PuzzlesAndAlgorithms.Tests.ProjectEuler
{
    [TestClass()]
    public class MultiplesOf3And5Tests
    {
        [TestMethod()]
        public void GetMultiplesOf3And5WithZeroBounds()
        {
            var sut = new MultiplesOf3And5();
            Assert.AreEqual(0, sut.GetMultiplesOf3And5(0));
        }

        [TestMethod()]
        public void GetMultiplesOf3And5With10Bounds()
        {
            var sut = new MultiplesOf3And5();
            Assert.AreEqual(23, sut.GetMultiplesOf3And5(10));
        }

        [TestMethod()]
        public void GetMultiplesOf3And5With1000Bounds()
        {
            var sut = new MultiplesOf3And5();
            Assert.AreEqual(233168, sut.GetMultiplesOf3And5(1000));
        }
    }
}
