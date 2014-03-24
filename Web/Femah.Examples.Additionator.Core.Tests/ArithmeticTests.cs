using NUnit.Framework;
using Shouldly;

namespace Femah.Examples.Additionator.Core.Tests
{
    public class ArithmeticTests
    {
        [Test]
        public void AddsNumbersCorrectly()
        {
            int a = 1;
            int b = 3;
            int expectedResult = 4;

            var arithmetic = new Arithmetic();
            var result = arithmetic.Add(a, b);

            result.ShouldBe(expectedResult);
        }

        [Test]
        public void AddsNegativeNumbersCorrectly()
        {
            int a = -3;
            int b = -7;
            int expectedResult = -10;

            var arithmetic = new Arithmetic();
            var result = arithmetic.Add(a, b);
            result.ShouldBe(expectedResult);
        }

        [Test]
        public void AddingZeroIsIdempotent()
        {
            int a = 3;
            int expectedResult = 3;

            var arithmetic = new Arithmetic();
            var result = arithmetic.Add(a, 0);
            result.ShouldBe(expectedResult);
        }

        [Test]
        public void AddingShouldBeCommutative()
        {
            int a = 3;
            int b = 7;

            var arithmetic = new Arithmetic();
            var firstResult = arithmetic.Add(a, b);
            var secondResult = arithmetic.Add(b, a);

            firstResult.ShouldBe(secondResult);
        }

//        [Test]
//        public void TestSelenium()
//        {
//
//        }
    }
}
