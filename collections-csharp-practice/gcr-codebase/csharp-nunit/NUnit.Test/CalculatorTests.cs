using NUnit.Framework;
using UnitTesting;
using System;

namespace UnitTesting.NUnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator = null!;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.That(_calculator.Add(10, 5), Is.EqualTo(15));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            Assert.That(_calculator.Subtract(10, 5), Is.EqualTo(5));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.That(_calculator.Multiply(4, 5), Is.EqualTo(20));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() =>
                _calculator.Divide(10, 0));
        }
    }
}
