using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;   // this must match your MAIN project namespace
using System;


namespace MS.test
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator = null!;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.AreEqual(15, _calculator.Add(10, 5));
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            Assert.AreEqual(5, _calculator.Subtract(10, 5));
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.AreEqual(20, _calculator.Multiply(4, 5));
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            try
            {
                _calculator.Divide(10, 0);
                Assert.Fail("Expected DivideByZeroException was not thrown.");
            }
            catch (DivideByZeroException)
            {
                // Test passes
            }
        }
    }
}
