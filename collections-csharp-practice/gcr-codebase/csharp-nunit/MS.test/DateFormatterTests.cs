using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class DateFormatterTests
    {
        private DateFormatter _formatter = null!;

        [TestInitialize]
        public void Setup()
        {
            _formatter = new DateFormatter();
        }

        // ✅ Valid date test
        [TestMethod]
        public void FormatDate_ValidDate_ReturnsFormattedDate()
        {
            string result = _formatter.FormatDate("2024-01-27");

            Assert.AreEqual("27-01-2024", result);
        }

        // ❌ Invalid format test
        [TestMethod]
        public void FormatDate_InvalidFormat_ThrowsFormatException()
        {
            try
            {
                _formatter.FormatDate("27-01-2024");
                Assert.Fail("Expected FormatException was not thrown.");
            }
            catch (FormatException)
            {
                // Test passed
            }
        }

        // ❌ Invalid date value test
        [TestMethod]
        public void FormatDate_InvalidDate_ThrowsFormatException()
        {
            try
            {
                _formatter.FormatDate("2024-13-40");
                Assert.Fail("Expected FormatException was not thrown.");
            }
            catch (FormatException)
            {
                // Test passed
            }
        }

        // ❌ Null or empty input
        [TestMethod]
        public void FormatDate_NullOrEmpty_ThrowsFormatException()
        {
            try
            {
                _formatter.FormatDate("");
                Assert.Fail("Expected FormatException was not thrown.");
            }
            catch (FormatException)
            {
                // Test passed
            }
        }
    }
}
