using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class MathUtilsTests
    {
        private MathUtils _mathUtils = null!;

        [TestInitialize]
        public void Setup()
        {
            _mathUtils = new MathUtils();
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            try
            {
                _mathUtils.Divide(10, 0);
                Assert.Fail("Expected ArithmeticException was not thrown.");
            }
            catch (ArithmeticException)
            {
                // Test passes
            }
        }
    }
}
