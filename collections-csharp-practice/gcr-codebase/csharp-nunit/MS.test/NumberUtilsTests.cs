using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class NumberUtilsTests
    {
        private NumberUtils _numberUtils = null!;

        [TestInitialize]
        public void Setup()
        {
            _numberUtils = new NumberUtils();
        }

        // 🔹 Parameterized Test
        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(4, true)]
        [DataRow(6, true)]
        [DataRow(7, false)]
        [DataRow(9, false)]
        public void IsEven_MultipleValues_ReturnsExpectedResult(int number, bool expected)
        {
            bool result = _numberUtils.IsEven(number);
            Assert.AreEqual(expected, result);
        }
    }
}
