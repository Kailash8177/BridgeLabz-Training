using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace NUnit.Test
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account = null!;

        [SetUp]
        public void Setup()
        {
            _account = new BankAccount(1000);
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            _account.Deposit(500);

            Assert.AreEqual(1500, _account.GetBalance());
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            _account.Withdraw(300);

            Assert.AreEqual(700, _account.GetBalance());
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                _account.Withdraw(2000);
            });
        }
    }
}
