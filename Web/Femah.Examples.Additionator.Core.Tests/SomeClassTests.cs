using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using SomeApplication.Core;

namespace Femah.Examples.Additionator.Core.Tests
{
    [TestClass]
    public class ArithmeticTests
    {
        [TestMethod]
        public void AddsNumbersCorrectly()
        {
            int a = 1;
            int b = 3;
            int expectedResult = 4;

            var arithmetic = new Arithmetic();
            var result = arithmetic.Add(a, b);

            result.ShouldBe(expectedResult);
        }

        [TestMethod]
        public void AddsNegativeNumbersCorrectly()
        {
            int a = -3;
            int b = -7;
            int expectedResult = -10;

            var arithmetic = new Arithmetic();
            var result = arithmetic.Add(a, b);
            result.ShouldBe(expectedResult);
        }

        [TestMethod]
        public void AddingZeroIsIdempotent()
        {
            int a = 3;
            int expectedResult = 3;

            var arithmetic = new Arithmetic();
            var result = arithmetic.Add(a, 0);
            result.ShouldBe(expectedResult);
        }

        [TestMethod]
        public void AddingShouldBeCommutative()
        {
            int a = 3;
            int b = 7;

            var arithmetic = new Arithmetic();
            var firstResult = arithmetic.Add(a, b);
            var secondResult = arithmetic.Add(b, a);

            firstResult.ShouldBe(secondResult);
        }

        [TestMethod]
        public void TestSelenium()
        {

        }
    }
}
