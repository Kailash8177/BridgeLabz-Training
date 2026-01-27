using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils = null!;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void Reverse_ValidString_ReturnsReversedString()
        {
            Assert.That(_stringUtils.Reverse("hello"), Is.EqualTo("olleh"));
        }

        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            Assert.IsTrue(_stringUtils.IsPalindrome("madam"));
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            Assert.IsFalse(_stringUtils.IsPalindrome("hello"));
        }

        [Test]
        public void ToUpperCase_LowerCaseString_ReturnsUpperCase()
        {
            Assert.That(_stringUtils.ToUpperCase("hello"), Is.EqualTo("HELLO"));
        }
    }
}
