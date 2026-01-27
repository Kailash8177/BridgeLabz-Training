using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration _registration = null!;

        [SetUp]
        public void Setup()
        {
            _registration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ValidInput_ReturnsTrue()
        {
            Assert.IsTrue(
                _registration.RegisterUser(
                    "john_doe",
                    "john@example.com",
                    "Password1"
                )
            );
        }

        [TestCase("", "john@example.com", "Password1")]
        [TestCase("john", "invalid-email", "Password1")]
        [TestCase("john", "john@example.com", "123")]
        public void RegisterUser_InvalidInput_ThrowsArgumentException(
            string username, string email, string password)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _registration.RegisterUser(username, email, password);
            });
        }
    }
}
