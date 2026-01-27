using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter _formatter = null!;

        [SetUp]
        public void Setup()
        {
            _formatter = new DateFormatter();
        }

        [Test]
        public void FormatDate_ValidDate_ReturnsFormattedDate()
        {
            string result = _formatter.FormatDate("2024-01-27");

            Assert.AreEqual("27-01-2024", result);
        }

        [TestCase("27-01-2024")]
        [TestCase("2024/01/27")]
        [TestCase("2024-13-40")]
        [TestCase("")]
        public void FormatDate_InvalidInput_ThrowsFormatException(string input)
        {
            Assert.Throws<FormatException>(() =>
            {
                _formatter.FormatDate(input);
            });
        }
    }
}
