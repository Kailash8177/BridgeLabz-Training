using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator _validator = null!;

        [SetUp]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        [TestCase("Secure123", true)]
        [TestCase("Abc12", false)]        // too short
        [TestCase("password1", false)]    // no uppercase
        [TestCase("Password", false)]     // no digit
        [TestCase("", false)]
        public void IsValid_MultiplePasswords_ReturnsExpectedResult(
            string password, bool expected)
        {
            Assert.AreEqual(expected, _validator.IsValid(password));
        }
    }
}
