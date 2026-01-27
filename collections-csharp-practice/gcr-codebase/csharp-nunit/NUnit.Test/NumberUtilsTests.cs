using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class NumberUtilsTests
    {
        private NumberUtils _numberUtils = null!;

        [SetUp]
        public void Setup()
        {
            _numberUtils = new NumberUtils();
        }

        // 🔹 Parameterized Test
        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_MultipleValues_ReturnsExpectedResult(int number, bool expected)
        {
            Assert.AreEqual(expected, _numberUtils.IsEven(number));
        }
    }
}
