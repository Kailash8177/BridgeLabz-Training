using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class MathUtilsTests
    {
        private MathUtils _mathUtils = null!;

        [SetUp]
        public void Setup()
        {
            _mathUtils = new MathUtils();
        }

        [Test]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                _mathUtils.Divide(10, 0);
            });
        }
    }
}
