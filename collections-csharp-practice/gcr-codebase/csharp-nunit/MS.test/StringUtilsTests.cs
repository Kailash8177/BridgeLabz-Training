using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils = null!;

        [TestInitialize]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        // 🔹 Reverse Tests
        [TestMethod]
        public void Reverse_ValidString_ReturnsReversedString()
        {
            string result = _stringUtils.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        // 🔹 Palindrome Tests
        [TestMethod]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            bool result = _stringUtils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            bool result = _stringUtils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        // 🔹 ToUpperCase Tests
        [TestMethod]
        public void ToUpperCase_LowerCaseString_ReturnsUpperCase()
        {
            string result = _stringUtils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }
    }
}
