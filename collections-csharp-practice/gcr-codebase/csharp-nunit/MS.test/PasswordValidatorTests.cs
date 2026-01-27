using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class PasswordValidatorTests
    {
        private PasswordValidator _validator = null!;

        [TestInitialize]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        // ✅ Valid password
        [TestMethod]
        public void IsValid_ValidPassword_ReturnsTrue()
        {
            bool result = _validator.IsValid("Secure123");

            Assert.IsTrue(result);
        }

        // ❌ Less than 8 characters
        [TestMethod]
        public void IsValid_ShortPassword_ReturnsFalse()
        {
            bool result = _validator.IsValid("Abc12");

            Assert.IsFalse(result);
        }

        // ❌ No uppercase letter
        [TestMethod]
        public void IsValid_NoUpperCase_ReturnsFalse()
        {
            bool result = _validator.IsValid("password1");

            Assert.IsFalse(result);
        }

        // ❌ No digit
        [TestMethod]
        public void IsValid_NoDigit_ReturnsFalse()
        {
            bool result = _validator.IsValid("Password");

            Assert.IsFalse(result);
        }

        // ❌ Null or empty password
        [TestMethod]
        public void IsValid_NullOrEmpty_ReturnsFalse()
        {
            Assert.IsFalse(_validator.IsValid(null));
            Assert.IsFalse(_validator.IsValid(""));
        }
    }
}
