using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.ProjectEuler;

namespace PuzzlesAndAlgorithms.Tests.ProjectEuler
{
    [TestClass()]
    public class SumOfEvenFibonacciTests
    {
        [TestMethod()]
        public void GetSumOfEvenFibonacciWithZeroBounds()
        {
            var sut = new SumOfEvenFibonacci();
            Assert.AreEqual(0, sut.GetSumOfEvenFibonacci(0));
        }

        [TestMethod()]
        public void GetGetSumOfEvenFibonacciWith10Bounds()
        {
            var sut = new SumOfEvenFibonacci();
            Assert.AreEqual(10, sut.GetSumOfEvenFibonacci(10));
        }


        [TestMethod()]
        public void GetGetSumOfEvenFibonacciWith89Bounds()
        {
            var sut = new SumOfEvenFibonacci();
            Assert.AreEqual(188, sut.GetSumOfEvenFibonacci(89));
        }
        
        [TestMethod()]
        public void GetGetSumOfEvenFibonacciWith4MillionBounds()
        {
            var sut = new SumOfEvenFibonacci();
            Assert.AreEqual(4613732, sut.GetSumOfEvenFibonacci(4000000));
        }
    }
}
