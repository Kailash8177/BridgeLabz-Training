using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class UserRegistrationTests
    {
        private UserRegistration _registration = null!;

        [TestInitialize]
        public void Setup()
        {
            _registration = new UserRegistration();
        }

        // ✅ Valid registration
        [TestMethod]
        public void RegisterUser_ValidInput_ReturnsTrue()
        {
            bool result = _registration.RegisterUser(
                "john_doe",
                "john@example.com",
                "Password1"
            );

            Assert.IsTrue(result);
        }

        // ❌ Invalid username
        [TestMethod]
        public void RegisterUser_InvalidUsername_ThrowsArgumentException()
        {
            try
            {
                _registration.RegisterUser(
                    "",
                    "john@example.com",
                    "Password1"
                );
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException)
            {
                // Test passed
            }
        }

        // ❌ Invalid email
        [TestMethod]
        public void RegisterUser_InvalidEmail_ThrowsArgumentException()
        {
            try
            {
                _registration.RegisterUser(
                    "john",
                    "invalid-email",
                    "Password1"
                );
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException)
            {
                // Test passed
            }
        }

        // ❌ Invalid password
        [TestMethod]
        public void RegisterUser_InvalidPassword_ThrowsArgumentException()
        {
            try
            {
                _registration.RegisterUser(
                    "john",
                    "john@example.com",
                    "123"
                );
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException)
            {
                // Test passed
            }
        }
    }
}
