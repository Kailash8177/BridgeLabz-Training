using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace MS.test
{
    [TestClass]
    public class BankAccountTests
    {
        private BankAccount _account = null!;

        [TestInitialize]
        public void Setup()
        {
            _account = new BankAccount(1000);
        }

        // ✅ Deposit test
        [TestMethod]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            _account.Deposit(500);

            Assert.AreEqual(1500, _account.GetBalance());
        }

        // ✅ Withdraw test
        [TestMethod]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            _account.Withdraw(300);

            Assert.AreEqual(700, _account.GetBalance());
        }

        // ✅ Insufficient balance test (TRY–CATCH SAFE)
        [TestMethod]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            try
            {
                _account.Withdraw(2000);
                Assert.Fail("Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException)
            {
                // Test passed
            }
        }
    }
}
